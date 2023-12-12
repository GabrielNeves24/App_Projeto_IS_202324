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
            this.btnRemoverSelecionado = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxSubscription = new System.Windows.Forms.GroupBox();
            this.btnDeleteSubscription = new System.Windows.Forms.Button();
            this.listBoxSubscription = new System.Windows.Forms.ListBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.textBoxSubscribeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxContainerInSubscription = new System.Windows.Forms.ComboBox();
            this.comboBoxEvento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteMessage = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.textBoxSendMessage = new System.Windows.Forms.TextBox();
            this.listBoxMessages = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxApplication.SuspendLayout();
            this.groupBoxContainer.SuspendLayout();
            this.groupBoxSubscription.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // 
            // listBoxContainer
            // 
            this.listBoxContainer.FormattingEnabled = true;
            this.listBoxContainer.Location = new System.Drawing.Point(9, 69);
            this.listBoxContainer.Name = "listBoxContainer";
            this.listBoxContainer.Size = new System.Drawing.Size(196, 160);
            this.listBoxContainer.TabIndex = 35;
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
            // btnRemoverSelecionado
            // 
            this.btnRemoverSelecionado.Location = new System.Drawing.Point(225, 101);
            this.btnRemoverSelecionado.Name = "btnRemoverSelecionado";
            this.btnRemoverSelecionado.Size = new System.Drawing.Size(123, 23);
            this.btnRemoverSelecionado.TabIndex = 39;
            this.btnRemoverSelecionado.Text = "Remover Selecionado";
            this.btnRemoverSelecionado.UseVisualStyleBackColor = true;
            this.btnRemoverSelecionado.Click += new System.EventHandler(this.btnRemoverSelecionado_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 525);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(1178, 23);
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
            this.groupBoxSubscription.Location = new System.Drawing.Point(796, 42);
            this.groupBoxSubscription.Name = "groupBoxSubscription";
            this.groupBoxSubscription.Size = new System.Drawing.Size(534, 340);
            this.groupBoxSubscription.TabIndex = 40;
            this.groupBoxSubscription.TabStop = false;
            this.groupBoxSubscription.Text = "Subscription (Select Container First)";
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
            this.listBoxSubscription.Size = new System.Drawing.Size(196, 173);
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
            // comboBoxContainerInSubscription
            // 
            this.comboBoxContainerInSubscription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContainerInSubscription.FormattingEnabled = true;
            this.comboBoxContainerInSubscription.Location = new System.Drawing.Point(109, 81);
            this.comboBoxContainerInSubscription.Name = "comboBoxContainerInSubscription";
            this.comboBoxContainerInSubscription.Size = new System.Drawing.Size(151, 21);
            this.comboBoxContainerInSubscription.TabIndex = 39;
            // 
            // comboBoxEvento
            // 
            this.comboBoxEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEvento.FormattingEnabled = true;
            this.comboBoxEvento.Location = new System.Drawing.Point(109, 108);
            this.comboBoxEvento.Name = "comboBoxEvento";
            this.comboBoxEvento.Size = new System.Drawing.Size(151, 21);
            this.comboBoxEvento.TabIndex = 40;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Evento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnDeleteMessage);
            this.groupBox1.Controls.Add(this.listBoxData);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.textBoxSendMessage);
            this.groupBox1.Location = new System.Drawing.Point(12, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 235);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Messages";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Remover Selecionado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMessage
            // 
            this.btnDeleteMessage.Location = new System.Drawing.Point(225, 73);
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
            this.listBoxData.Location = new System.Drawing.Point(9, 69);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(196, 160);
            this.listBoxData.TabIndex = 35;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(225, 31);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(123, 23);
            this.btnEnviar.TabIndex = 33;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // textBoxSendMessage
            // 
            this.textBoxSendMessage.Location = new System.Drawing.Point(9, 31);
            this.textBoxSendMessage.Name = "textBoxSendMessage";
            this.textBoxSendMessage.Size = new System.Drawing.Size(196, 20);
            this.textBoxSendMessage.TabIndex = 32;
            // 
            // listBoxMessages
            // 
            this.listBoxMessages.FormattingEnabled = true;
            this.listBoxMessages.Location = new System.Drawing.Point(395, 369);
            this.listBoxMessages.Name = "listBoxMessages";
            this.listBoxMessages.Size = new System.Drawing.Size(395, 134);
            this.listBoxMessages.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Eventos Recebidos";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 595);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxMessages);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSubscription);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBoxContainer);
            this.Controls.Add(this.groupBoxApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.ListBox listBoxMessages;
        private System.Windows.Forms.Label label6;
    }
}

