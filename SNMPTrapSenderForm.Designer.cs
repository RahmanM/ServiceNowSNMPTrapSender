namespace SNMP.Trap.Sender
{
    partial class SNMPTrapSenderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SNMPTrapSenderForm));
            this.tblMaster = new System.Windows.Forms.TableLayoutPanel();
            this.cmdSend = new System.Windows.Forms.Button();
            this.grpMessage = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResource = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tblMaster.SuspendLayout();
            this.grpMessage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMaster
            // 
            this.tblMaster.ColumnCount = 2;
            this.tblMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMaster.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tblMaster.Controls.Add(this.cmdSend, 1, 2);
            this.tblMaster.Controls.Add(this.grpMessage, 0, 1);
            this.tblMaster.Controls.Add(this.groupBox2, 0, 0);
            this.tblMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMaster.Location = new System.Drawing.Point(0, 0);
            this.tblMaster.Margin = new System.Windows.Forms.Padding(2);
            this.tblMaster.Name = "tblMaster";
            this.tblMaster.RowCount = 4;
            this.tblMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tblMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblMaster.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblMaster.Size = new System.Drawing.Size(406, 451);
            this.tblMaster.TabIndex = 5;
            // 
            // cmdSend
            // 
            this.cmdSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSend.Location = new System.Drawing.Point(318, 397);
            this.cmdSend.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(86, 28);
            this.cmdSend.TabIndex = 7;
            this.cmdSend.Text = "Send Trap";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // grpMessage
            // 
            this.tblMaster.SetColumnSpan(this.grpMessage, 2);
            this.grpMessage.Controls.Add(this.txtMessage);
            this.grpMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMessage.Location = new System.Drawing.Point(2, 164);
            this.grpMessage.Margin = new System.Windows.Forms.Padding(2);
            this.grpMessage.Name = "grpMessage";
            this.grpMessage.Padding = new System.Windows.Forms.Padding(2);
            this.grpMessage.Size = new System.Drawing.Size(402, 229);
            this.grpMessage.TabIndex = 6;
            this.grpMessage.TabStop = false;
            this.grpMessage.Text = "SNMP Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(2, 15);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(398, 212);
            this.txtMessage.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.tblMaster.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(402, 158);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel2.Controls.Add(this.txtPort, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtHost, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDescription, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtResource, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(398, 141);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtPort
            // 
            this.txtPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPort.Location = new System.Drawing.Point(92, 34);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(225, 20);
            this.txtPort.TabIndex = 2;
            // 
            // txtHost
            // 
            this.txtHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHost.Location = new System.Drawing.Point(92, 2);
            this.txtHost.Margin = new System.Windows.Forms.Padding(2);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(225, 20);
            this.txtHost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port To Send";
            // 
            // txtDescription
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtDescription, 2);
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(92, 66);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(304, 45);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "Database timeout error!";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // txtResource
            // 
            this.txtResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResource.Location = new System.Drawing.Point(92, 115);
            this.txtResource.Margin = new System.Windows.Forms.Padding(2);
            this.txtResource.Name = "txtResource";
            this.txtResource.Size = new System.Drawing.Size(225, 20);
            this.txtResource.TabIndex = 4;
            this.txtResource.Text = "MySQL Server@rahman-hp";
            this.txtResource.TextChanged += new System.EventHandler(this.txtResource_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(2, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resource";
            // 
            // SNMPTrapSenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 451);
            this.Controls.Add(this.tblMaster);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SNMPTrapSenderForm";
            this.Text = "Rahman SNMP Trap Sender";
            this.Load += new System.EventHandler(this.SNMPTrapSenderForm_Load);
            this.tblMaster.ResumeLayout(false);
            this.grpMessage.ResumeLayout(false);
            this.grpMessage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblMaster;
        private System.Windows.Forms.GroupBox grpMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResource;
        private System.Windows.Forms.Label label4;
    }
}

