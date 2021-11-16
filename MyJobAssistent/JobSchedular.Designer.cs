
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNotificationInititor = new System.Windows.Forms.Button();
            this.btnEmailInitiator = new System.Windows.Forms.Button();
            this.btnRecurring = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddEndPoint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 58);
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
            this.comboBox1.Location = new System.Drawing.Point(168, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Web API Job";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jobs To Execute";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "https://utility.liveoptics.com/v2/api/restartservice/id/007";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNotificationInititor);
            this.groupBox1.Controls.Add(this.btnEmailInitiator);
            this.groupBox1.Controls.Add(this.btnRecurring);
            this.groupBox1.Controls.Add(this.btnSchedule);
            this.groupBox1.Location = new System.Drawing.Point(53, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configure";
            // 
            // btnNotificationInititor
            // 
            this.btnNotificationInititor.Location = new System.Drawing.Point(488, 41);
            this.btnNotificationInititor.Name = "btnNotificationInititor";
            this.btnNotificationInititor.Size = new System.Drawing.Size(125, 35);
            this.btnNotificationInititor.TabIndex = 3;
            this.btnNotificationInititor.Text = "With Notification";
            this.btnNotificationInititor.UseVisualStyleBackColor = true;
            this.btnNotificationInititor.Click += new System.EventHandler(this.btnNotificationInititor_Click);
            // 
            // btnEmailInitiator
            // 
            this.btnEmailInitiator.Location = new System.Drawing.Point(333, 42);
            this.btnEmailInitiator.Name = "btnEmailInitiator";
            this.btnEmailInitiator.Size = new System.Drawing.Size(125, 35);
            this.btnEmailInitiator.TabIndex = 2;
            this.btnEmailInitiator.Text = "With Email";
            this.btnEmailInitiator.UseVisualStyleBackColor = true;
            this.btnEmailInitiator.Click += new System.EventHandler(this.btnEmailInitiator_Click);
            // 
            // btnRecurring
            // 
            this.btnRecurring.Location = new System.Drawing.Point(178, 43);
            this.btnRecurring.Name = "btnRecurring";
            this.btnRecurring.Size = new System.Drawing.Size(125, 35);
            this.btnRecurring.TabIndex = 1;
            this.btnRecurring.Text = "As Recurrance";
            this.btnRecurring.UseVisualStyleBackColor = true;
            this.btnRecurring.Click += new System.EventHandler(this.btnRecurring_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(23, 43);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(125, 35);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "With Date Time";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(58, 329);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(267, 329);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(135, 23);
            this.btnExecute.TabIndex = 7;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Web API",
            "Winodws Process",
            "Remote Process"});
            this.comboBox2.Location = new System.Drawing.Point(557, 107);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "   ------  Select a Job  ------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "or";
            // 
            // btnAddEndPoint
            // 
            this.btnAddEndPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEndPoint.Location = new System.Drawing.Point(740, 102);
            this.btnAddEndPoint.Name = "btnAddEndPoint";
            this.btnAddEndPoint.Size = new System.Drawing.Size(38, 28);
            this.btnAddEndPoint.TabIndex = 10;
            this.btnAddEndPoint.Text = "+";
            this.btnAddEndPoint.UseVisualStyleBackColor = true;
            // 
            // JobSchedular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddEndPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnNotificationInititor;
        private System.Windows.Forms.Button btnEmailInitiator;
        private System.Windows.Forms.Button btnRecurring;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddEndPoint;
    }
}