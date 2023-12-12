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
            //change bellow
            //if button is create then post else put 
            if (btnCreateNewApplication.Text == "Create")
            {
                var request = new RestSharp.RestRequest("", RestSharp.Method.Post);
                request.RequestFormat = RestSharp.DataFormat.Xml;
                request.AddXmlBody(xmlDoc);

                RestResponse response = client.Execute(request);
                if (response.IsSuccessStatusCode)
                {
                    getAllApplicationsRequest();
                    textBoxNewApplication.Clear();
                    //go get all applications again
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

            //var request = new RestSharp.RestRequest("", RestSharp.Method.Post);
            //request.RequestFormat = RestSharp.DataFormat.Xml;
            //request.AddXmlBody(xmlDoc);

            //RestResponse response = client.Execute(request);
            //if (response.IsSuccessStatusCode)
            //{
            //    //fetchAllApplicationsRequest();
            //    textBoxNewApplication.Clear();
            //}
            //else
            //{
            //    MessageBox.Show(response.Content);
            //}

        }

        private void btnGetAllApplications_Click(object sender, EventArgs e)
        {
            getAllApplicationsRequest();
        }

        private void listBoxApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            //se nao selecionar nada nao faz nada
            if (listBoxApplications.SelectedItem == null)
            {
                return;
            }
            getAllContainersRequest();
            btnCreateNewApplication.Text = "Update";
            textBoxNewApplication.Text = listBoxApplications.SelectedItem.ToString();
            string applicationSelected = listBoxApplications.SelectedItem.ToString();
            string newApplicationName = textBoxNewApplication.Text;
            //if (applicationSelected == null || applicationSelected == "")
            //{
            //    MessageBox.Show("No Application selected");
            //    return;
            //}

            //if (newApplicationName == null || newApplicationName == "")
            //{
            //    MessageBox.Show("Empty application name");
            //    return;
            //}

            //XmlDocument doc = new XmlDocument();

            //try
            //{
            //    doc.Load("app_" + applicationSelected + @".xml");
            //}
            //catch (XmlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //var namedoc = doc.SelectSingleNode("/Application");
            //namedoc.SelectSingleNode("name").InnerText = newApplicationName;
            //doc.Save("app_" + newApplicationName + @".xml");

            ////ir buscar o xml com o content
            //XElement xmlDoc = XElement.Load("app_" + newApplicationName + @".xml");

            //var request = new RestSharp.RestRequest("/" + applicationSelected, RestSharp.Method.Put);
            //request.RequestFormat = RestSharp.DataFormat.Xml;
            //request.AddXmlBody(xmlDoc);

            //RestSharp.RestResponse response = client.Execute(request);

            //if (response.IsSuccessStatusCode)
            //{
            //    getAllApplicationsRequest();
            //    textBoxNewApplication.Clear();
            //    btnCreateNewApplication.Text = "Create";
            //}
            //else
            //{
            //    MessageBox.Show(response.Content);
            //}
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


        //

        private void getAllContainersRequest()
        {
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

            // Create xml with Module Name
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
            }
            else
            {
                MessageBox.Show(response.Content);
            }
        }
    }
}
