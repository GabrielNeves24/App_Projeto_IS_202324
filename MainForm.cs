using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using RestSharp;
using System.Xml.Linq;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using ProjectXML;
using App_Projeto_IS_202324.Models;
using System.Linq;
using System.Text;

public struct clientSubscriptions
{
    public int ids { get; set; }

    public string name { get; set; }
    public string eventos { get; set; }

    public clientSubscriptions(int id, string evento, string nameString)
    {
        ids = id;
        eventos = evento;
        name = nameString;
    }
}

public struct clientData
{
    public int ids { get; set; }
    public string contents { get; set; }

    public clientData(int id, string content)
    {
        ids = id;
        contents = content;
    }
}

namespace App_Projeto_IS_202324
{
    public partial class MainForm : Form
    {
        private RestClient client = new RestSharp.RestClient(@"http://localhost:60917/api/somiod");
        private List<clientSubscriptions> subscriptionList = new List<clientSubscriptions> { };
        private List<clientData> dataList = new List<clientData> { };
        

        // Create a new MqttClient
        private MqttClient clientMqtt = new MqttClient("localhost");

        public MainForm()
        {
            InitializeComponent();
            clientMqtt.Connect(Guid.NewGuid().ToString());
            getAllApplicationsRequest();
            comboBoxEvento.Items.Add("creation");
            comboBoxEvento.Items.Add("deletion");
        }
        private List<T> FetchRequestToURLByRequestType<T>(string url, Method methodType)
        {
            var request = new RestRequest(url, methodType);
            request.RequestFormat = DataFormat.Xml;

            return client.Execute<List<T>>(request).Data;
        }

        private void getAllApplicationsRequest()
        {
            var applicationData = FetchRequestToURLByRequestType<Models.Application>("/applications", Method.Get);

            listBoxApplications.Items.Clear();
            if (applicationData == null || applicationData.Count == 0)
            {
                MessageBox.Show("No Applications exist for this application");
                return;
            }
            foreach (Models.Application item in applicationData)
            {
                string name = item.ToString();
                listBoxApplications.Items.Add(item.name);
                comboBoxAppClient.Items.Add(item.name);
            }
        }

        private void btnCreateNewApplication_Click(object sender, EventArgs e)
        {
            var applicationName = textBoxNewApplication.Text;
            if (applicationName == null || applicationName == "")
            {
                MessageBox.Show("Empty application name");
                return;
            }

            XmlDocument doc = new XmlDocument();
            // Create the XML Declaration, and append it to XML document
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);

            // Create the root element
            XmlElement root = doc.CreateElement("Application");
            doc.AppendChild(root);

            XmlElement name = doc.CreateElement("name");
            name.InnerText = applicationName;

            root.AppendChild(name);

            doc.Save("app_" + applicationName + @".xml");


            XElement xmlDoc = XElement.Load("app_" + applicationName + @".xml");
            HandlerXML handle = new HandlerXML("app_" + applicationName + @".xml", @"application.xsd");
            if (!handle.ValidateXML())
            {
                MessageBox.Show("Invalid XML");
                return;
            }

            if (btnCreateNewApplication.Text == "Create new")
            {
                var request = new RestSharp.RestRequest("", RestSharp.Method.Post);
                request.RequestFormat = RestSharp.DataFormat.Xml;
                request.AddXmlBody(xmlDoc);

                RestResponse response = client.Execute(request);
                if (response.IsSuccessStatusCode)
                {
                    getAllApplicationsRequest();
                    textBoxNewApplication.Clear();

                }
                else
                {
                    MessageBox.Show(response.Content);
                }
            }
            else
            {
                string applicationSelected = listBoxApplications.GetItemText(listBoxApplications.SelectedItem);
                var request = new RestSharp.RestRequest("/" + applicationSelected, RestSharp.Method.Put);
                request.RequestFormat = RestSharp.DataFormat.Xml;
                request.AddXmlBody(xmlDoc);

                RestResponse response = client.Execute(request);
                if (response.IsSuccessStatusCode)
                {
                    getAllApplicationsRequest();
                    textBoxNewApplication.Clear();
                    btnCreateNewApplication.Text = "Create";
                }
                else
                {
                    MessageBox.Show(response.Content);
                }
            }

        }

        private void btnGetAllApplications_Click(object sender, EventArgs e)
        {
            getAllApplicationsRequest();
        }

        private void listBoxApplications_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxApplications.SelectedItem == null)
            {
                comboBoxContainerInSubscription.Items.Clear();
                return;
            }
            getAllContainersRequest();
            btnCreateNewApplication.Text = "Update";
            textBoxNewApplication.Text = listBoxApplications.SelectedItem.ToString();
            string applicationSelected = listBoxApplications.SelectedItem.ToString();
            string newApplicationName = textBoxNewApplication.Text;
            
        }

        private void btnDeleteApplication_Click(object sender, EventArgs e)
        {
            string applicationSelected = listBoxApplications.SelectedItem.ToString();
            if (applicationSelected == null || applicationSelected == "")
            {
                MessageBox.Show("No Application selected");
                return;
            }

            var request = new RestSharp.RestRequest("/" + applicationSelected, RestSharp.Method.Delete);
            request.RequestFormat = RestSharp.DataFormat.Xml;

            RestSharp.RestResponse response = client.Execute(request);

            if (response.IsSuccessStatusCode)
            {
                getAllApplicationsRequest();
            }
            else
            {
                MessageBox.Show(response.Content);
            }
        }

        private void getAllContainersRequest()
        {
            comboBoxContainerInSubscription.Items.Clear();
            string applicationSelected = listBoxApplications.GetItemText(listBoxApplications.SelectedItem);
            labelApplicationName.Visible = true;
            labelApplicationName.Text = applicationSelected;
            if (applicationSelected == null || applicationSelected == "")
            {
                MessageBox.Show("No Application selected");
                return;
            }

            var containerData = FetchRequestToURLByRequestType<Container>("/" + applicationSelected + "/containers", Method.Get);

            listBoxContainer.Items.Clear();
            if (containerData == null || containerData.Count == 0)
            {
                MessageBox.Show("No containers exist for this application");
                return;
            }
            foreach (Container item in containerData)
            {
                listBoxContainer.Items.Add(item.name);
                comboBoxContainerInSubscription.Items.Add(item.name);
            }
        }

        private void btnGetAllContainers_Click(object sender, EventArgs e)
        {
            getAllContainersRequest();
        }

        private void btnCreateNewContainer_Click(object sender, EventArgs e)
        {
            string applicationSelected = listBoxApplications.GetItemText(listBoxApplications.SelectedItem);
            var containerName = textBoxNewContainer.Text;
            if (applicationSelected == null || applicationSelected == "")
            {
                MessageBox.Show("No Application selected");
                return;
            }

            if (containerName == null || containerName == "")
            {
                MessageBox.Show("Empty container name");
                return;
            }

            XmlDocument doc = new XmlDocument();
            // Create the XML Declaration, and append it to XML document
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);

            // Create the root element
            XmlElement root = doc.CreateElement("Container");
            doc.AppendChild(root);

            // Create xml with Container Name
            XmlElement name = doc.CreateElement("name");
            name.InnerText = containerName;

            root.AppendChild(name);

            doc.Save("container_" + containerName + @".xml");

            //ir buscar o xml com o content
            XElement xmlDoc = XElement.Load("container_" + containerName + @".xml");
            HandlerXML handle = new HandlerXML("container_" + containerName + @".xml", @"container.xsd");
            if (!handle.ValidateXML())
            {
                MessageBox.Show("Invalid XML");
                return;
            }
            //change bellow
            var request = new RestSharp.RestRequest("/" + applicationSelected, RestSharp.Method.Post);
            request.RequestFormat = RestSharp.DataFormat.Xml;
            request.AddXmlBody(xmlDoc);

            RestSharp.RestResponse response = client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
                getAllContainersRequest();
                textBoxNewContainer.Clear();
                //reload 
                comboBoxAppClient_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show(response.Content);
            }
        }

        private void btnRemoverSelecionado_Click(object sender, EventArgs e)
        {
            listBoxApplications.ClearSelected();
            btnCreateNewApplication.Text = "Create new";
            textBoxNewApplication.Clear();
            listBoxContainer.Items.Clear();
            comboBoxContainerInSubscription.Items.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            string applicationSelected = listBoxApplications.GetItemText(listBoxApplications.SelectedItem);
            string containerSelected = comboBoxContainerInSubscription.GetItemText(comboBoxContainerInSubscription.SelectedItem);
            var subscriptionName = textBoxSubscribeName.Text;
            var eventType = comboBoxEvento.SelectedItem;
            if (applicationSelected == null || applicationSelected == "")
            {
                MessageBox.Show("No Application selected");
                return;
            }

            if (containerSelected == null || containerSelected == "")
            {
                MessageBox.Show("No Containers selected");
                return;
            }

            if (subscriptionName == null || subscriptionName == "")
            {
                MessageBox.Show("Empty Subscription Name");
                return;
            }

            if (eventType == null || eventType.ToString() == "")
            {
                MessageBox.Show("No Subscription event selected");
                return;
            }


            if (eventType.ToString() == "both")
            {
                List<clientSubscriptions> existingSubscriptionListForThisTopic = subscriptionList.FindAll(
                    s => s.eventos.Contains(applicationSelected + "/" + containerSelected + "/")
                );

                if (existingSubscriptionListForThisTopic.Count == 2)
                {
                    MessageBox.Show("Both types of events are already active");
                    return;
                }
                else if (existingSubscriptionListForThisTopic.Count == 1)
                {
                    eventType = "creation";
                    if (existingSubscriptionListForThisTopic[0].eventos.Contains("creation"))
                    {
                        eventType = "deletion";
                    }
                }
            }

            clientSubscriptions subscription = subscriptionList.Find(
                s => s.eventos == applicationSelected + "/" + containerSelected + "/" + eventType
            );
            if (subscription.ids != 0)
            {
                MessageBox.Show("This subscription event already exists");
                return;
            }

            XmlDocument doc = new XmlDocument();
            // Create the XML Declaration, and append it to XML document
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);

            // Create the root element
            XmlElement root = doc.CreateElement("Subscription");
            doc.AppendChild(root);

            // Create xml with Subscription Name
            XmlElement name = doc.CreateElement("name");
            name.InnerText = subscriptionName;
            root.AppendChild(name);

            //Create xml with event type
            XmlElement @event = doc.CreateElement("event");
            @event.InnerText = eventType.ToString();
            root.AppendChild(@event);

            doc.Save("sub_" + subscriptionName + @".xml");

            //ir buscar o xml com o content
            XElement xmlDoc = XElement.Load("sub_" + subscriptionName + @".xml");
            HandlerXML handle = new HandlerXML("sub_" + subscriptionName + @".xml", @"subscription.xsd");
            if (!handle.ValidateXML())
            {
                MessageBox.Show("Invalid XML");
                return;
            }
            var request = new RestSharp.RestRequest("/" + applicationSelected + "/" + containerSelected + "/subscription", RestSharp.Method.Post);
            request.RequestFormat = RestSharp.DataFormat.Xml;
            request.AddXmlBody(xmlDoc);

            request.AddHeader("Accept", "application/xml");
            RestSharp.RestResponse response = client.Execute(request);

            if (response.IsSuccessStatusCode)
            {
                XmlDocument newXmlObject = new XmlDocument();
                newXmlObject.LoadXml(response.Content);
                XmlNodeList xmlSubscriptionNodeList = newXmlObject.SelectNodes("//*[local-name()='Subscription']");
                foreach (XmlNode item in xmlSubscriptionNodeList)
                {
                    int subscriptionId = int.Parse(item["id"].InnerText);
                    string eventName = item["endpoint"].InnerText.Split('/').Last();
                    subscriptionList.Add(new clientSubscriptions(subscriptionId, applicationSelected + "/" + containerSelected + "/" + eventName, subscriptionName));

                    listBoxSubscription.Items.Add(subscriptionId + ". " + item["endpoint"].InnerText);
                    textBoxSubscribeName.Clear();
                }
            }
            else
            {
                MessageBox.Show(response.Content);
            }
        }

        //Mqtt
        public void SubscribeToTopic(string[] topicName, ListBox listBox)
        {
            byte[] mqtMsgBase = new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE };
            if (topicName.Length > 1)
            {
                Array.Resize(ref mqtMsgBase, mqtMsgBase.Length + 1);
                mqtMsgBase[mqtMsgBase.Length - 1] = MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE;
            }

            clientMqtt.Subscribe(topicName, mqtMsgBase);

           foreach (string topic in topicName)
            {
                clientMqtt.MqttMsgPublishReceived += (sender, e) => handleNotificationEventsClientSide(listBox, topic, sender, e);
            }
        }
        public void UnsubscribeFromTopic(string[] topicName)
        {
            clientMqtt.Unsubscribe(topicName);
        }


        private void handleNotificationEventsClientSide(ListBox listBox, string topicName, object sender, MqttMsgPublishEventArgs e)
        {
            string messageReceived = $"{e.Topic}: {Encoding.UTF8.GetString(e.Message)}";
            if (topicName == e.Topic)
            {
                if (listBox.InvokeRequired)
                {
                    listBox.Invoke((Action)(() => listBox.Items.Add(messageReceived)));
                    return;
                }

                listBox.Items.Add(messageReceived);
            }
        }

        private string[] FindAndReturnSubtopicNames(string evento, string application, string container)
        {
            string[] topicNames = { };

            if (evento == "creation" || evento == "deletion")
            {
                Array.Resize(ref topicNames, topicNames.Length + 1);
                topicNames[topicNames.Length - 1] = application + "/" + container + "/" + evento;
            }
            // if both, add 2 elements to array by extending array
            if (evento == "both")
            {
                Array.Resize(ref topicNames, topicNames.Length + 2);
                topicNames[topicNames.Length - 2] = application + "/" + container + "/" + "creation";
                topicNames[topicNames.Length - 1] = application + "/" + container + "/" + "deletion";
            }
            return topicNames;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteSubscription_Click(object sender, EventArgs e)
        {
            string subscriptionSelected = listBoxSubscription.GetItemText(listBoxSubscription.SelectedItem);
            string applicationSelected = listBoxApplications.GetItemText(listBoxApplications.SelectedItem);
            string containerSelected = listBoxContainer.GetItemText(listBoxContainer.SelectedItem);
            if (applicationSelected == null || applicationSelected == "")
            {
                MessageBox.Show("No Application selected");
                return;
            }

            if (containerSelected == null || containerSelected == "")
            {
                MessageBox.Show("No Container selected");
                return;
            }
            if (subscriptionSelected == null || subscriptionSelected == "")
            {
                MessageBox.Show("No Subscription selected");
                return;
            }

            string subscriptionId = subscriptionSelected.Split('.').First();
            clientSubscriptions subscription = subscriptionList.Find(s => s.ids == int.Parse(subscriptionId));

            XElement xmlElement = XElement.Load("sub_" + subscription.name + @".xml");

            var request = new RestSharp.RestRequest("/" + applicationSelected + "/" + containerSelected + "/subscription/" + subscriptionId, Method.Delete);
            request.RequestFormat = RestSharp.DataFormat.Xml;
            request.AddBody(xmlElement);
            RestSharp.RestResponse response = client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
                listBoxSubscription.Items.Remove(subscriptionSelected);
                subscriptionList.Remove(subscription);
                UnsubscribeFromTopic(new[] { subscription.eventos });
            }
            else
            {
                MessageBox.Show(response.Content);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string applicationSelected = listBoxApplications.GetItemText(listBoxApplications.SelectedItem);
            string containerSelected = listBoxApplications.GetItemText(listBoxContainer.SelectedItem);
            var dataContent = textBoxSendMessage.Text;
            if (applicationSelected == null || applicationSelected == "")
            {
                MessageBox.Show("No Application selected");
                return;
            }

            if (containerSelected == null || containerSelected == "")
            {
                MessageBox.Show("No Container selected");
                return;
            }

            if (dataContent == null || dataContent == "")
            {
                MessageBox.Show("No content set in message");
                return;
            }

            XmlDocument doc = new XmlDocument();
            // Create the XML Declaration, and append it to XML document
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);

            // Create the root element
            XmlElement root = doc.CreateElement("Data");
            // Set Attribute on Request element in order to know which type of XML object we want to access
            doc.AppendChild(root);

            // Create xml with Subscription Name
            XmlElement content = doc.CreateElement("content");
            content.InnerText = dataContent;

            root.AppendChild(content);

            doc.Save("data_" + dataContent + @".xml");

            //ir buscar o xml com o content
            XElement xmlDoc = XElement.Load("data_" + dataContent + @".xml");
            HandlerXML handle = new HandlerXML("data_" + dataContent + @".xml", @"data.xsd");
            if (!handle.ValidateXML())
            {
                MessageBox.Show("Invalid XML");
                return;
            }
            var request = new RestSharp.RestRequest("/" + applicationSelected + "/" + containerSelected + "/data", RestSharp.Method.Post);

            request.RequestFormat = RestSharp.DataFormat.Xml;
            request.AddXmlBody(xmlDoc);
            request.AddHeader("Accept", "application/xml");
            RestSharp.RestResponse response = client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
                textBoxSendMessage.Clear();

                XmlDocument newXmlObject = new XmlDocument();
                newXmlObject.LoadXml(response.Content);
                XmlNodeList xmlDataNodeList = newXmlObject.SelectNodes("//*[local-name()='Data']");
                foreach (XmlNode item in xmlDataNodeList)
                {
                    int dataId = int.Parse(item["id"].InnerText);
                    dataList.Add(new clientData { ids = dataId, contents = dataContent });
                    listBoxData.Items.Add(dataId + ". " + dataContent);
                }
            }
            else
            {
                MessageBox.Show(response.Content);
            }
        }

        private void btnDeleteMessage_Click(object sender, EventArgs e)
        {
            string applicationSelected = listBoxApplications.GetItemText(listBoxApplications.SelectedItem);
            string containerSelected = listBoxContainer.GetItemText(listBoxContainer.SelectedItem);
            string dataSelected = listBoxData.GetItemText(listBoxData.SelectedItem);
            if (applicationSelected == null || applicationSelected == "")
            {
                MessageBox.Show("No Application selected");
                return;
            }

            if (containerSelected == null || containerSelected == "")
            {
                MessageBox.Show("No Container selected");
                return;
            }
            if (dataSelected == null || dataSelected == "")
            {
                MessageBox.Show("No Data selected");
                return;
            }

            string dataId = dataSelected.Split('.').First();
            clientData clientData = dataList.Find(s => s.ids == int.Parse(dataId));

            XElement xmlElement = XElement.Load("data_" + clientData.contents + @".xml");

            var request = new RestSharp.RestRequest("/" + applicationSelected + "/" + containerSelected + "/data/" + dataId, Method.Delete);
            request.RequestFormat = RestSharp.DataFormat.Xml;
            request.AddBody(xmlElement);
            RestSharp.RestResponse response = client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
                listBoxData.Items.Remove(dataSelected);
            }
            else
            {
                MessageBox.Show(response.Content);
            }
        }

        private void listBoxContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //after select show on listBoxSubscription the subscriptions for that container
            string applicationSelected = listBoxApplications.GetItemText(listBoxApplications.SelectedItem);
            string containerSelected = listBoxContainer.GetItemText(listBoxContainer.SelectedItem);
            if (applicationSelected == null || applicationSelected == "")
            {
                MessageBox.Show("No Application selected");
                return;
            }

            if (containerSelected == null || containerSelected == "")
            {
                MessageBox.Show("No Container selected");
                return;
            }

            var subscriptionData = FetchRequestToURLByRequestType<Subscription>("/" + applicationSelected + "/" + containerSelected + "/subscription", Method.Get);

            listBoxSubscription.Items.Clear();
            if (subscriptionData == null || subscriptionData.Count == 0)
            {
                MessageBox.Show("No subscriptions exist for this container");
                return;
            }
            foreach (Subscription item in subscriptionData)
            {
                listBoxSubscription.Items.Add(item.id + ". " + item.endpoint);
                subscriptionList.Add(new clientSubscriptions(item.id, item.endpoint, item.name));
            }

        }

        private void comboBoxEvento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOuvir_Click(object sender, EventArgs e)
        {
            //clear listbox
            listBoxMessages.Items.Clear();
            string applicationSelected = comboBoxAppClient.GetItemText(comboBoxAppClient.SelectedItem);
            string containerSelected = comboBoxContainerAppClient.GetItemText(comboBoxContainerAppClient.SelectedItem);
            string eventType = "";
            //to eventType make a request to know if is creation or deletion or existes the 2
            var subscriptionData = FetchRequestToURLByRequestType<Subscription>("/" + applicationSelected + "/" + containerSelected + "/subscription", Method.Get);
            if (subscriptionData == null || subscriptionData.Count == 0)
            {
                MessageBox.Show("No subscriptions exist for this container");
                return;
            }
            if (subscriptionData.Count == 1)
            {
                foreach (Subscription item in subscriptionData)
                {
                    eventType = item.endpoint.Split('/').Last();
                }
            }
            if (subscriptionData.Count == 2)
            {
                eventType = "both";
            }


            //need to make a post to know if is creation or deletion or existes the 
            if (applicationSelected == null || applicationSelected == "")
            {
                MessageBox.Show("No Application selected");
                return;
            }

                
            try
            {
                FindAndReturnSubtopicNames(eventType, applicationSelected, containerSelected);
                SubscribeToTopic(FindAndReturnSubtopicNames(eventType, applicationSelected, containerSelected), listBoxMessages);
                labelConection.Visible = true;
                labelConection.Text = "Connected";
                labelConection.ForeColor = System.Drawing.Color.Green;
                //lock button
                btnOuvir.Enabled = false;
            }catch(Exception ex)
            {
                labelConection.Visible = true;
                labelConection.Text = "Not Connectioned";
                labelConection.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void comboBoxAppClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxContainerAppClient.Items.Clear();
            if (comboBoxAppClient.SelectedIndex == -1)
            {
                MessageBox.Show("No Application selected");
                return;
            }
            
            string applicationSelected = comboBoxAppClient.SelectedItem.ToString();
            var containerData = FetchRequestToURLByRequestType<Container>("/" + applicationSelected + "/containers", Method.Get);

            if (containerData == null || containerData.Count == 0)
            {
                MessageBox.Show("No containers exist for this application");
                return;
            }
            foreach (Container item in containerData)
            {
                comboBoxContainerAppClient.Items.Add(item.name);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {

            listBoxMessages.Items.Clear();
            string applicationSelected = comboBoxAppClient.GetItemText(comboBoxAppClient.SelectedItem);
            string containerSelected = comboBoxContainerAppClient.GetItemText(comboBoxContainerAppClient.SelectedItem);
            string eventType = "";

            var subscriptionData = FetchRequestToURLByRequestType<Subscription>("/" + applicationSelected + "/" + containerSelected + "/subscription", Method.Get);
            if (subscriptionData == null || subscriptionData.Count == 0)
            {
                MessageBox.Show("No subscriptions exist for this container");
                return;
            }
            if (subscriptionData.Count == 1)
            {
                foreach (Subscription item in subscriptionData)
                {
                    eventType = item.endpoint.Split('/').Last();
                }
            }
            if (subscriptionData.Count == 2)
            {
                eventType = "both";
            }
            try
            {
                FindAndReturnSubtopicNames(eventType, applicationSelected, containerSelected);
                UnsubscribeFromTopic(FindAndReturnSubtopicNames(eventType, applicationSelected, containerSelected));
                labelConection.Visible = true;
                labelConection.Text = "Disconnected";
                labelConection.ForeColor = System.Drawing.Color.Red;

                btnOuvir.Enabled = true;
            }
            catch (Exception ex)
            {
                labelConection.Visible = true;
                labelConection.Text = "Not Connectioned";
                labelConection.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnDeleteContainer_Click(object sender, EventArgs e)
        {

            string applicationSelected = listBoxApplications.GetItemText(listBoxApplications.SelectedItem);
            string containerSelected = listBoxContainer.GetItemText(listBoxContainer.SelectedItem);
            if (applicationSelected == null || applicationSelected == "")
            {
                MessageBox.Show("No Application selected");
                return;
            }
            if(containerSelected == null || containerSelected == "")
            {
                MessageBox.Show("No Container selected");
                return;
            }
            var request = new RestSharp.RestRequest("/" + applicationSelected + "/" + containerSelected, RestSharp.Method.Delete);
            request.RequestFormat = RestSharp.DataFormat.Xml;

            RestSharp.RestResponse response = client.Execute(request);

            if (response.IsSuccessStatusCode)
            {
                getAllContainersRequest();
                MessageBox.Show("Container deleted");   
                listBoxSubscription.Items.Clear();
            }
            else
            {
                MessageBox.Show(response.Content);
            }


        }

        private void btnCreateXML_Click(object sender, EventArgs e)
        {
            string applicationSelected = listBoxApplications.GetItemText(listBoxApplications.SelectedItem);
            string containerSelected = listBoxApplications.GetItemText(listBoxContainer.SelectedItem);
            var dataContent = textBoxSendMessage.Text;
            if (applicationSelected == null || applicationSelected == "")
            {
                MessageBox.Show("No Application selected");
                return;
            }

            if (containerSelected == null || containerSelected == "")
            {
                MessageBox.Show("No Container selected");
                return;
            }

            if (dataContent == null || dataContent == "")
            {
                MessageBox.Show("No content set in message");
                return;
            }
            // -------------------------Criar XML---------------------------------
            XmlDocument doc = new XmlDocument();
            // Create the XML Declaration, and append it to XML document
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);

            // Create the root element
            XmlElement root = doc.CreateElement("Data");
            // Set Attribute on Request element in order to know which type of XML object we want to access
            doc.AppendChild(root);

            // Create xml with Subscription Name
            XmlElement content = doc.CreateElement("content");
            content.InnerText = dataContent;

            root.AppendChild(content);
            // -------------------------FIM Criar XML---------------------------------

            // Pergunta onde quer guardar o ficheiro
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save XML File";
            saveFileDialog.FileName = "data_" + dataContent + ".xml";

            //se guardar o ficheiro bem dá ok
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                doc.Save(filePath);
                MessageBox.Show("Criado XML com sucesso");
            }            
        }

        private void btnSendXML_Click(object sender, EventArgs e)
        {
            // Pergunta onde está o ficheiro
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog.Title = "Open XML File";
            string applicationSelected = listBoxApplications.GetItemText(listBoxApplications.SelectedItem);
            string containerSelected = listBoxApplications.GetItemText(listBoxContainer.SelectedItem);

            // Se ficheiro for válido envia para a api
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                XElement xmlDoc = XElement.Load(filePath);
                HandlerXML handle = new HandlerXML(filePath, @"data.xsd");
                if (!handle.ValidateXML())
                {
                    MessageBox.Show("Invalid XML");
                    return;
                }

                //pedido post
                var request = new RestSharp.RestRequest("/" + applicationSelected + "/" + containerSelected + "/data", RestSharp.Method.Post);
                request.RequestFormat = RestSharp.DataFormat.Xml;
                request.AddXmlBody(xmlDoc);
                request.AddHeader("Accept", "application/xml");
                RestSharp.RestResponse response = client.Execute(request);

                //pedido enviado e com resposta 200 sucesso então:
                if (response.IsSuccessStatusCode)
                {
                    textBoxSendMessage.Clear();
                    //carregar o ficheiro xml com a resposta e mostrar na listbox
                    XmlDocument newXmlObject = new XmlDocument();
                    newXmlObject.LoadXml(response.Content);
                    XmlNodeList xmlDataNodeList = newXmlObject.SelectNodes("//*[local-name()='Data']");
                    foreach (XmlNode item in xmlDataNodeList)
                    {
                        int dataId = int.Parse(item["id"].InnerText);
                        dataList.Add(new clientData { ids = dataId, contents = item["content"].InnerText });
                        listBoxData.Items.Add(dataId + ". " + item["content"].InnerText);
                    }
                }
                else
                {
                    MessageBox.Show(response.Content);
                }
            }
        }
    }
}
