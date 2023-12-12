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
            this.groupBoxApplication.SuspendLayout();
            this.groupBoxContainer.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(12, 283);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(768, 23);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 454);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBoxContainer);
            this.Controls.Add(this.groupBoxApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBoxApplication.ResumeLayout(false);
            this.groupBoxApplication.PerformLayout();
            this.groupBoxContainer.ResumeLayout(false);
            this.groupBoxContainer.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

