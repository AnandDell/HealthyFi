
namespace MyJobAssistent
{
    partial class JobSchedular
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJobEndPoint = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNotificationInititor = new System.Windows.Forms.Button();
            this.btnEmailInitiator = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbBoxJobType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Job Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Windows job",
            "Remote Job",
            "Web API Job",
            "Health Analysis Job",
            "Monitoring Job"});
            this.comboBox1.Location = new System.Drawing.Point(148, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Web API Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jobs To Execute";
            // 
            // txtJobEndPoint
            // 
            this.txtJobEndPoint.Location = new System.Drawing.Point(146, 108);
            this.txtJobEndPoint.Name = "txtJobEndPoint";
            this.txtJobEndPoint.Size = new System.Drawing.Size(397, 20);
            this.txtJobEndPoint.TabIndex = 4;
            this.txtJobEndPoint.Text = "https://utility.liveoptics.com/v2/api/restartservice";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNotificationInititor);
            this.groupBox1.Controls.Add(this.btnEmailInitiator);
            this.groupBox1.Controls.Add(this.btnSchedule);
            this.groupBox1.Location = new System.Drawing.Point(34, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configure";
            // 
            // btnNotificationInititor
            // 
            this.btnNotificationInititor.Location = new System.Drawing.Point(501, 41);
            this.btnNotificationInititor.Name = "btnNotificationInititor";
            this.btnNotificationInititor.Size = new System.Drawing.Size(125, 35);
            this.btnNotificationInititor.TabIndex = 3;
            this.btnNotificationInititor.Text = "With Notification";
            this.btnNotificationInititor.UseVisualStyleBackColor = true;
            this.btnNotificationInititor.Click += new System.EventHandler(this.btnNotificationInititor_Click);
            // 
            // btnEmailInitiator
            // 
            this.btnEmailInitiator.Location = new System.Drawing.Point(300, 41);
            this.btnEmailInitiator.Name = "btnEmailInitiator";
            this.btnEmailInitiator.Size = new System.Drawing.Size(125, 35);
            this.btnEmailInitiator.TabIndex = 2;
            this.btnEmailInitiator.Text = "With Email";
            this.btnEmailInitiator.UseVisualStyleBackColor = true;
            this.btnEmailInitiator.Click += new System.EventHandler(this.btnEmailInitiator_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(84, 41);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(125, 35);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "With Date Time";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(119, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 39);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbBoxJobType
            // 
            this.cmbBoxJobType.FormattingEnabled = true;
            this.cmbBoxJobType.Items.AddRange(new object[] {
            "Web API",
            "Winodws Process",
            "Remote Process"});
            this.cmbBoxJobType.Location = new System.Drawing.Point(595, 107);
            this.cmbBoxJobType.Name = "cmbBoxJobType";
            this.cmbBoxJobType.Size = new System.Drawing.Size(141, 21);
            this.cmbBoxJobType.TabIndex = 8;
            this.cmbBoxJobType.Text = "   ------  Select a Job  ------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "or";
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(146, 52);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(397, 20);
            this.txtEndPoint.TabIndex = 12;
            this.txtEndPoint.Text = "https://utility.liveoptics.com/v2/api/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Endpoint To Correct";
            // 
            // JobSchedular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEndPoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBoxJobType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtJobEndPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "JobSchedular";
            this.Text = "Job Schedular";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJobEndPoint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnNotificationInititor;
        private System.Windows.Forms.Button btnEmailInitiator;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbBoxJobType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Label label4;
    }
}