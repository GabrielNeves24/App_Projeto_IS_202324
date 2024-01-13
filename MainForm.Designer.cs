namespace App_Projeto_IS_202324
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxApplication = new System.Windows.Forms.GroupBox();
            this.btnRemoverSelecionado = new System.Windows.Forms.Button();
            this.btnDeleteApplication = new System.Windows.Forms.Button();
            this.listBoxApplications = new System.Windows.Forms.ListBox();
            this.btnGetAllApplications = new System.Windows.Forms.Button();
            this.btnCreateNewApplication = new System.Windows.Forms.Button();
            this.textBoxNewApplication = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxContainer = new System.Windows.Forms.GroupBox();
            this.labelApplicationName = new System.Windows.Forms.Label();
            this.btnDeleteContainer = new System.Windows.Forms.Button();
            this.listBoxContainer = new System.Windows.Forms.ListBox();
            this.btnGetAllContainers = new System.Windows.Forms.Button();
            this.btnCreateNewContainer = new System.Windows.Forms.Button();
            this.textBoxNewContainer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxSubscription = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEvento = new System.Windows.Forms.ComboBox();
            this.comboBoxContainerInSubscription = new System.Windows.Forms.ComboBox();
            this.btnDeleteSubscription = new System.Windows.Forms.Button();
            this.listBoxSubscription = new System.Windows.Forms.ListBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.textBoxSubscribeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteMessage = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.textBoxSendMessage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.labelConection = new System.Windows.Forms.Label();
            this.btnOuvir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxContainerAppClient = new System.Windows.Forms.ComboBox();
            this.comboBoxAppClient = new System.Windows.Forms.ComboBox();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.btnCreateXML = new System.Windows.Forms.Button();
            this.btnSendXML = new System.Windows.Forms.Button();
            this.groupBoxApplication.SuspendLayout();
            this.groupBoxContainer.SuspendLayout();
            this.groupBoxSubscription.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBoxApplication
            // 
            this.groupBoxApplication.Controls.Add(this.btnRemoverSelecionado);
            this.groupBoxApplication.Controls.Add(this.btnDeleteApplication);
            this.groupBoxApplication.Controls.Add(this.listBoxApplications);
            this.groupBoxApplication.Controls.Add(this.btnGetAllApplications);
            this.groupBoxApplication.Controls.Add(this.btnCreateNewApplication);
            this.groupBoxApplication.Controls.Add(this.textBoxNewApplication);
            this.groupBoxApplication.Controls.Add(this.label1);
            this.groupBoxApplication.Location = new System.Drawing.Point(12, 42);
            this.groupBoxApplication.Name = "groupBoxApplication";
            this.groupBoxApplication.Size = new System.Drawing.Size(361, 235);
            this.groupBoxApplication.TabIndex = 31;
            this.groupBoxApplication.TabStop = false;
            this.groupBoxApplication.Text = "Application";
            // 
            // btnRemoverSelecionado
            // 
            this.btnRemoverSelecionado.Location = new System.Drawing.Point(225, 101);
            this.btnRemoverSelecionado.Name = "btnRemoverSelecionado";
            this.btnRemoverSelecionado.Size = new System.Drawing.Size(123, 23);
            this.btnRemoverSelecionado.TabIndex = 39;
            this.btnRemoverSelecionado.Text = "Remove Selected";
            this.btnRemoverSelecionado.UseVisualStyleBackColor = true;
            this.btnRemoverSelecionado.Click += new System.EventHandler(this.btnRemoverSelecionado_Click);
            // 
            // btnDeleteApplication
            // 
            this.btnDeleteApplication.Location = new System.Drawing.Point(225, 72);
            this.btnDeleteApplication.Name = "btnDeleteApplication";
            this.btnDeleteApplication.Size = new System.Drawing.Size(123, 23);
            this.btnDeleteApplication.TabIndex = 38;
            this.btnDeleteApplication.Text = "Delete";
            this.btnDeleteApplication.UseVisualStyleBackColor = true;
            this.btnDeleteApplication.Click += new System.EventHandler(this.btnDeleteApplication_Click);
            // 
            // listBoxApplications
            // 
            this.listBoxApplications.FormattingEnabled = true;
            this.listBoxApplications.Location = new System.Drawing.Point(9, 69);
            this.listBoxApplications.Name = "listBoxApplications";
            this.listBoxApplications.Size = new System.Drawing.Size(196, 160);
            this.listBoxApplications.TabIndex = 35;
            this.listBoxApplications.SelectedIndexChanged += new System.EventHandler(this.listBoxApplications_SelectedIndexChanged);
            // 
            // btnGetAllApplications
            // 
            this.btnGetAllApplications.Location = new System.Drawing.Point(225, 206);
            this.btnGetAllApplications.Name = "btnGetAllApplications";
            this.btnGetAllApplications.Size = new System.Drawing.Size(123, 23);
            this.btnGetAllApplications.TabIndex = 34;
            this.btnGetAllApplications.Text = "Gell All Aplications";
            this.btnGetAllApplications.UseVisualStyleBackColor = true;
            this.btnGetAllApplications.Click += new System.EventHandler(this.btnGetAllApplications_Click);
            // 
            // btnCreateNewApplication
            // 
            this.btnCreateNewApplication.Location = new System.Drawing.Point(225, 43);
            this.btnCreateNewApplication.Name = "btnCreateNewApplication";
            this.btnCreateNewApplication.Size = new System.Drawing.Size(123, 23);
            this.btnCreateNewApplication.TabIndex = 33;
            this.btnCreateNewApplication.Text = "Create new";
            this.btnCreateNewApplication.UseVisualStyleBackColor = true;
            this.btnCreateNewApplication.Click += new System.EventHandler(this.btnCreateNewApplication_Click);
            // 
            // textBoxNewApplication
            // 
            this.textBoxNewApplication.Location = new System.Drawing.Point(9, 43);
            this.textBoxNewApplication.Name = "textBoxNewApplication";
            this.textBoxNewApplication.Size = new System.Drawing.Size(196, 20);
            this.textBoxNewApplication.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Application Name";
            // 
            // groupBoxContainer
            // 
            this.groupBoxContainer.Controls.Add(this.labelApplicationName);
            this.groupBoxContainer.Controls.Add(this.btnDeleteContainer);
            this.groupBoxContainer.Controls.Add(this.listBoxContainer);
            this.groupBoxContainer.Controls.Add(this.btnGetAllContainers);
            this.groupBoxContainer.Controls.Add(this.btnCreateNewContainer);
            this.groupBoxContainer.Controls.Add(this.textBoxNewContainer);
            this.groupBoxContainer.Controls.Add(this.label2);
            this.groupBoxContainer.Location = new System.Drawing.Point(386, 42);
            this.groupBoxContainer.Name = "groupBoxContainer";
            this.groupBoxContainer.Size = new System.Drawing.Size(394, 235);
            this.groupBoxContainer.TabIndex = 39;
            this.groupBoxContainer.TabStop = false;
            this.groupBoxContainer.Text = "Container";
            // 
            // labelApplicationName
            // 
            this.labelApplicationName.AutoSize = true;
            this.labelApplicationName.Location = new System.Drawing.Point(222, 16);
            this.labelApplicationName.Name = "labelApplicationName";
            this.labelApplicationName.Size = new System.Drawing.Size(57, 13);
            this.labelApplicationName.TabIndex = 39;
            this.labelApplicationName.Text = "App Name";
            this.labelApplicationName.Visible = false;
            // 
            // btnDeleteContainer
            // 
            this.btnDeleteContainer.Location = new System.Drawing.Point(225, 72);
            this.btnDeleteContainer.Name = "btnDeleteContainer";
            this.btnDeleteContainer.Size = new System.Drawing.Size(109, 23);
            this.btnDeleteContainer.TabIndex = 38;
            this.btnDeleteContainer.Text = "Delete";
            this.btnDeleteContainer.UseVisualStyleBackColor = true;
            this.btnDeleteContainer.Click += new System.EventHandler(this.btnDeleteContainer_Click);
            // 
            // listBoxContainer
            // 
            this.listBoxContainer.FormattingEnabled = true;
            this.listBoxContainer.Location = new System.Drawing.Point(9, 69);
            this.listBoxContainer.Name = "listBoxContainer";
            this.listBoxContainer.Size = new System.Drawing.Size(196, 160);
            this.listBoxContainer.TabIndex = 35;
            this.listBoxContainer.SelectedIndexChanged += new System.EventHandler(this.listBoxContainer_SelectedIndexChanged);
            // 
            // btnGetAllContainers
            // 
            this.btnGetAllContainers.Location = new System.Drawing.Point(225, 206);
            this.btnGetAllContainers.Name = "btnGetAllContainers";
            this.btnGetAllContainers.Size = new System.Drawing.Size(109, 23);
            this.btnGetAllContainers.TabIndex = 34;
            this.btnGetAllContainers.Text = "Gell All Containers";
            this.btnGetAllContainers.UseVisualStyleBackColor = true;
            this.btnGetAllContainers.Click += new System.EventHandler(this.btnGetAllContainers_Click);
            // 
            // btnCreateNewContainer
            // 
            this.btnCreateNewContainer.Location = new System.Drawing.Point(225, 43);
            this.btnCreateNewContainer.Name = "btnCreateNewContainer";
            this.btnCreateNewContainer.Size = new System.Drawing.Size(109, 23);
            this.btnCreateNewContainer.TabIndex = 33;
            this.btnCreateNewContainer.Text = "Create new";
            this.btnCreateNewContainer.UseVisualStyleBackColor = true;
            this.btnCreateNewContainer.Click += new System.EventHandler(this.btnCreateNewContainer_Click);
            // 
            // textBoxNewContainer
            // 
            this.textBoxNewContainer.Location = new System.Drawing.Point(9, 43);
            this.textBoxNewContainer.Name = "textBoxNewContainer";
            this.textBoxNewContainer.Size = new System.Drawing.Size(196, 20);
            this.textBoxNewContainer.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Container Name";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 531);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(1161, 23);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBoxSubscription
            // 
            this.groupBoxSubscription.Controls.Add(this.label5);
            this.groupBoxSubscription.Controls.Add(this.label3);
            this.groupBoxSubscription.Controls.Add(this.comboBoxEvento);
            this.groupBoxSubscription.Controls.Add(this.comboBoxContainerInSubscription);
            this.groupBoxSubscription.Controls.Add(this.btnDeleteSubscription);
            this.groupBoxSubscription.Controls.Add(this.listBoxSubscription);
            this.groupBoxSubscription.Controls.Add(this.btnSubscribe);
            this.groupBoxSubscription.Controls.Add(this.textBoxSubscribeName);
            this.groupBoxSubscription.Controls.Add(this.label4);
            this.groupBoxSubscription.Location = new System.Drawing.Point(12, 283);
            this.groupBoxSubscription.Name = "groupBoxSubscription";
            this.groupBoxSubscription.Size = new System.Drawing.Size(554, 237);
            this.groupBoxSubscription.TabIndex = 40;
            this.groupBoxSubscription.TabStop = false;
            this.groupBoxSubscription.Text = "Subscription (Select Container First)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Evento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Container";
            // 
            // comboBoxEvento
            // 
            this.comboBoxEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEvento.FormattingEnabled = true;
            this.comboBoxEvento.Location = new System.Drawing.Point(109, 108);
            this.comboBoxEvento.Name = "comboBoxEvento";
            this.comboBoxEvento.Size = new System.Drawing.Size(151, 21);
            this.comboBoxEvento.TabIndex = 40;
            this.comboBoxEvento.SelectedIndexChanged += new System.EventHandler(this.comboBoxEvento_SelectedIndexChanged);
            // 
            // comboBoxContainerInSubscription
            // 
            this.comboBoxContainerInSubscription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContainerInSubscription.FormattingEnabled = true;
            this.comboBoxContainerInSubscription.Location = new System.Drawing.Point(109, 81);
            this.comboBoxContainerInSubscription.Name = "comboBoxContainerInSubscription";
            this.comboBoxContainerInSubscription.Size = new System.Drawing.Size(151, 21);
            this.comboBoxContainerInSubscription.TabIndex = 39;
            // 
            // btnDeleteSubscription
            // 
            this.btnDeleteSubscription.Location = new System.Drawing.Point(11, 164);
            this.btnDeleteSubscription.Name = "btnDeleteSubscription";
            this.btnDeleteSubscription.Size = new System.Drawing.Size(249, 23);
            this.btnDeleteSubscription.TabIndex = 38;
            this.btnDeleteSubscription.Text = "Delete";
            this.btnDeleteSubscription.UseVisualStyleBackColor = true;
            this.btnDeleteSubscription.Click += new System.EventHandler(this.btnDeleteSubscription_Click);
            // 
            // listBoxSubscription
            // 
            this.listBoxSubscription.FormattingEnabled = true;
            this.listBoxSubscription.Location = new System.Drawing.Point(280, 43);
            this.listBoxSubscription.Name = "listBoxSubscription";
            this.listBoxSubscription.Size = new System.Drawing.Size(258, 173);
            this.listBoxSubscription.TabIndex = 35;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(11, 135);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(250, 23);
            this.btnSubscribe.TabIndex = 33;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // textBoxSubscribeName
            // 
            this.textBoxSubscribeName.Location = new System.Drawing.Point(109, 55);
            this.textBoxSubscribeName.Name = "textBoxSubscribeName";
            this.textBoxSubscribeName.Size = new System.Drawing.Size(151, 20);
            this.textBoxSubscribeName.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Subscription Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendXML);
            this.groupBox1.Controls.Add(this.btnCreateXML);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnDeleteMessage);
            this.groupBox1.Controls.Add(this.listBoxData);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.textBoxSendMessage);
            this.groupBox1.Location = new System.Drawing.Point(798, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 235);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Messages";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Remove Selected";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMessage
            // 
            this.btnDeleteMessage.Location = new System.Drawing.Point(225, 101);
            this.btnDeleteMessage.Name = "btnDeleteMessage";
            this.btnDeleteMessage.Size = new System.Drawing.Size(123, 23);
            this.btnDeleteMessage.TabIndex = 38;
            this.btnDeleteMessage.Text = "Delete";
            this.btnDeleteMessage.UseVisualStyleBackColor = true;
            this.btnDeleteMessage.Click += new System.EventHandler(this.btnDeleteMessage_Click);
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.Location = new System.Drawing.Point(9, 95);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(196, 134);
            this.listBoxData.TabIndex = 35;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(225, 66);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(123, 23);
            this.btnEnviar.TabIndex = 33;
            this.btnEnviar.Text = "Send";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // textBoxSendMessage
            // 
            this.textBoxSendMessage.Location = new System.Drawing.Point(9, 66);
            this.textBoxSendMessage.Name = "textBoxSendMessage";
            this.textBoxSendMessage.Size = new System.Drawing.Size(196, 20);
            this.textBoxSendMessage.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 41;
            this.label8.Text = "AppMain";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDisconnect);
            this.groupBox2.Controls.Add(this.labelConection);
            this.groupBox2.Controls.Add(this.btnOuvir);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBoxContainerAppClient);
            this.groupBox2.Controls.Add(this.comboBoxAppClient);
            this.groupBox2.Controls.Add(this.listBoxMessages);
            this.groupBox2.Location = new System.Drawing.Point(581, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 232);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(6, 203);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(214, 23);
            this.btnDisconnect.TabIndex = 66;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // labelConection
            // 
            this.labelConection.AutoSize = true;
            this.labelConection.Location = new System.Drawing.Point(80, 155);
            this.labelConection.Name = "labelConection";
            this.labelConection.Size = new System.Drawing.Size(59, 13);
            this.labelConection.TabIndex = 65;
            this.labelConection.Text = "Application";
            this.labelConection.Visible = false;
            // 
            // btnOuvir
            // 
            this.btnOuvir.Location = new System.Drawing.Point(6, 173);
            this.btnOuvir.Name = "btnOuvir";
            this.btnOuvir.Size = new System.Drawing.Size(214, 23);
            this.btnOuvir.TabIndex = 64;
            this.btnOuvir.Text = "Subscribe";
            this.btnOuvir.UseVisualStyleBackColor = true;
            this.btnOuvir.Click += new System.EventHandler(this.btnOuvir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 63;
            this.label9.Text = "AppClient";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Application";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Container";
            // 
            // comboBoxContainerAppClient
            // 
            this.comboBoxContainerAppClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContainerAppClient.FormattingEnabled = true;
            this.comboBoxContainerAppClient.Location = new System.Drawing.Point(76, 87);
            this.comboBoxContainerAppClient.Name = "comboBoxContainerAppClient";
            this.comboBoxContainerAppClient.Size = new System.Drawing.Size(144, 21);
            this.comboBoxContainerAppClient.TabIndex = 60;
            // 
            // comboBoxAppClient
            // 
            this.comboBoxAppClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAppClient.FormattingEnabled = true;
            this.comboBoxAppClient.Location = new System.Drawing.Point(76, 60);
            this.comboBoxAppClient.Name = "comboBoxAppClient";
            this.comboBoxAppClient.Size = new System.Drawing.Size(144, 21);
            this.comboBoxAppClient.TabIndex = 59;
            this.comboBoxAppClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxAppClient_SelectedIndexChanged);
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.Location = new System.Drawing.Point(245, 27);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(212, 199);
            this.listBoxMessages.TabIndex = 56;
            // 
            // btnCreateXML
            // 
            this.btnCreateXML.Location = new System.Drawing.Point(225, 11);
            this.btnCreateXML.Name = "btnCreateXML";
            this.btnCreateXML.Size = new System.Drawing.Size(123, 23);
            this.btnCreateXML.TabIndex = 40;
            this.btnCreateXML.Text = "CreateXML";
            this.btnCreateXML.UseVisualStyleBackColor = true;
            this.btnCreateXML.Click += new System.EventHandler(this.btnCreateXML_Click);
            // 
            // btnSendXML
            // 
            this.btnSendXML.Location = new System.Drawing.Point(225, 39);
            this.btnSendXML.Name = "btnSendXML";
            this.btnSendXML.Size = new System.Drawing.Size(123, 23);
            this.btnSendXML.TabIndex = 41;
            this.btnSendXML.Text = "SendXML";
            this.btnSendXML.UseVisualStyleBackColor = true;
            this.btnSendXML.Click += new System.EventHandler(this.btnSendXML_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSubscription);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBoxContainer);
            this.Controls.Add(this.groupBoxApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxApplication.ResumeLayout(false);
            this.groupBoxApplication.PerformLayout();
            this.groupBoxContainer.ResumeLayout(false);
            this.groupBoxContainer.PerformLayout();
            this.groupBoxSubscription.ResumeLayout(false);
            this.groupBoxSubscription.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.GroupBox groupBoxApplication;
        private System.Windows.Forms.Button btnDeleteApplication;
        private System.Windows.Forms.ListBox listBoxApplications;
        private System.Windows.Forms.Button btnGetAllApplications;
        private System.Windows.Forms.Button btnCreateNewApplication;
        private System.Windows.Forms.TextBox textBoxNewApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxContainer;
        private System.Windows.Forms.Button btnDeleteContainer;
        private System.Windows.Forms.ListBox listBoxContainer;
        private System.Windows.Forms.Button btnGetAllContainers;
        private System.Windows.Forms.Button btnCreateNewContainer;
        private System.Windows.Forms.TextBox textBoxNewContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelApplicationName;
        private System.Windows.Forms.Button btnRemoverSelecionado;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBoxSubscription;
        private System.Windows.Forms.Button btnDeleteSubscription;
        private System.Windows.Forms.ListBox listBoxSubscription;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.TextBox textBoxSubscribeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxContainerInSubscription;
        private System.Windows.Forms.ComboBox comboBoxEvento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeleteMessage;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox textBoxSendMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxContainerAppClient;
        private System.Windows.Forms.ComboBox comboBoxAppClient;
        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.Button btnOuvir;
        private System.Windows.Forms.Label labelConection;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnCreateXML;
        private System.Windows.Forms.Button btnSendXML;
    }
}

