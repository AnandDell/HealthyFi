
namespace MyJobAssistent
{
    partial class HealthConfig
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
            this.lblEndpoint1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddEndPoint = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.endPointTypeCmbBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnErrored = new System.Windows.Forms.Button();
            this.btnErrored2 = new System.Windows.Forms.Button();
            this.btnOk1 = new System.Windows.Forms.Button();
            this.btnErrored3 = new System.Windows.Forms.Button();
            this.btnOk2 = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnAnalyzeAndShow = new System.Windows.Forms.Button();
            this.btnAnalyzeAndSend = new System.Windows.Forms.Button();
            this.verticalLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblEndpoint1
            // 
            this.lblEndpoint1.AutoSize = true;
            this.lblEndpoint1.Location = new System.Drawing.Point(11, 264);
            this.lblEndpoint1.Name = "lblEndpoint1";
            this.lblEndpoint1.Size = new System.Drawing.Size(98, 13);
            this.lblEndpoint1.TabIndex = 0;
            this.lblEndpoint1.Text = "Enpoint to Connect";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "https://papi.liveoptics-dev.com/v2/api/public/pricing/77592";
            // 
            // btnAddEndPoint
            // 
            this.btnAddEndPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEndPoint.Location = new System.Drawing.Point(662, 22);
            this.btnAddEndPoint.Name = "btnAddEndPoint";
            this.btnAddEndPoint.Size = new System.Drawing.Size(22, 25);
            this.btnAddEndPoint.TabIndex = 2;
            this.btnAddEndPoint.Text = "+";
            this.btnAddEndPoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddEndPoint.UseVisualStyleBackColor = true;
            this.btnAddEndPoint.Click += new System.EventHandler(this.btnAddEndPoint_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 315);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "https://utility.liveoptics-dev.com/api/public/restartservice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enpoint to Connect";
            // 
            // endPointTypeCmbBox
            // 
            this.endPointTypeCmbBox.FormattingEnabled = true;
            this.endPointTypeCmbBox.Items.AddRange(new object[] {
            "Web API",
            "Windows Service",
            "Wcf Service",
            "Remoting"});
            this.endPointTypeCmbBox.Location = new System.Drawing.Point(498, 260);
            this.endPointTypeCmbBox.Name = "endPointTypeCmbBox";
            this.endPointTypeCmbBox.Size = new System.Drawing.Size(121, 21);
            this.endPointTypeCmbBox.TabIndex = 5;
            this.endPointTypeCmbBox.Text = "-- End Point Type --";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Web API",
            "Windows Service",
            "Wcf Service",
            "Remoting"});
            this.comboBox1.Location = new System.Drawing.Point(498, 314);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Web API";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Web API",
            "Windows Service",
            "Wcf Service",
            "Remoting"});
            this.comboBox2.Location = new System.Drawing.Point(498, 367);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Text = "Web API";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 368);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(338, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "https://support.liveoptics-dev.com/api/public/tickets/12345";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enpoint to Connect";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk.Location = new System.Drawing.Point(645, 260);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(24, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Visible = false;
            // 
            // btnErrored
            // 
            this.btnErrored.BackColor = System.Drawing.Color.Red;
            this.btnErrored.Location = new System.Drawing.Point(675, 260);
            this.btnErrored.Name = "btnErrored";
            this.btnErrored.Size = new System.Drawing.Size(24, 23);
            this.btnErrored.TabIndex = 11;
            this.btnErrored.UseVisualStyleBackColor = false;
            this.btnErrored.Visible = false;
            // 
            // btnErrored2
            // 
            this.btnErrored2.BackColor = System.Drawing.Color.Red;
            this.btnErrored2.Location = new System.Drawing.Point(675, 313);
            this.btnErrored2.Name = "btnErrored2";
            this.btnErrored2.Size = new System.Drawing.Size(24, 23);
            this.btnErrored2.TabIndex = 13;
            this.btnErrored2.UseVisualStyleBackColor = false;
            this.btnErrored2.Visible = false;
            // 
            // btnOk1
            // 
            this.btnOk1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk1.Location = new System.Drawing.Point(645, 313);
            this.btnOk1.Name = "btnOk1";
            this.btnOk1.Size = new System.Drawing.Size(24, 23);
            this.btnOk1.TabIndex = 12;
            this.btnOk1.UseVisualStyleBackColor = false;
            this.btnOk1.Visible = false;
            // 
            // btnErrored3
            // 
            this.btnErrored3.BackColor = System.Drawing.Color.Red;
            this.btnErrored3.Location = new System.Drawing.Point(675, 365);
            this.btnErrored3.Name = "btnErrored3";
            this.btnErrored3.Size = new System.Drawing.Size(24, 23);
            this.btnErrored3.TabIndex = 15;
            this.btnErrored3.UseVisualStyleBackColor = false;
            this.btnErrored3.Visible = false;
            // 
            // btnOk2
            // 
            this.btnOk2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk2.Location = new System.Drawing.Point(645, 365);
            this.btnOk2.Name = "btnOk2";
            this.btnOk2.Size = new System.Drawing.Size(24, 23);
            this.btnOk2.TabIndex = 14;
            this.btnOk2.UseVisualStyleBackColor = false;
            this.btnOk2.Visible = false;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(662, 73);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(135, 23);
            this.btnSaveConfig.TabIndex = 16;
            this.btnSaveConfig.Text = "Save Configuration";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnAnalyzeAndShow
            // 
            this.btnAnalyzeAndShow.Location = new System.Drawing.Point(662, 119);
            this.btnAnalyzeAndShow.Name = "btnAnalyzeAndShow";
            this.btnAnalyzeAndShow.Size = new System.Drawing.Size(135, 23);
            this.btnAnalyzeAndShow.TabIndex = 17;
            this.btnAnalyzeAndShow.Text = "Analyze and Show";
            this.btnAnalyzeAndShow.UseVisualStyleBackColor = true;
            this.btnAnalyzeAndShow.Click += new System.EventHandler(this.btnAnalyzeAndShow_Click);
            // 
            // btnAnalyzeAndSend
            // 
            this.btnAnalyzeAndSend.Location = new System.Drawing.Point(662, 168);
            this.btnAnalyzeAndSend.Name = "btnAnalyzeAndSend";
            this.btnAnalyzeAndSend.Size = new System.Drawing.Size(135, 23);
            this.btnAnalyzeAndSend.TabIndex = 18;
            this.btnAnalyzeAndSend.Text = "Analyze and Send";
            this.btnAnalyzeAndSend.UseVisualStyleBackColor = true;
            this.btnAnalyzeAndSend.Click += new System.EventHandler(this.btnAnalyzeAndSend_Click);
            // 
            // verticalLayoutPanel
            // 
            this.verticalLayoutPanel.AutoScroll = true;
            this.verticalLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verticalLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.verticalLayoutPanel.Location = new System.Drawing.Point(33, 22);
            this.verticalLayoutPanel.Name = "verticalLayoutPanel";
            this.verticalLayoutPanel.Size = new System.Drawing.Size(611, 211);
            this.verticalLayoutPanel.TabIndex = 19;
            // 
            // HealthConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verticalLayoutPanel);
            this.Controls.Add(this.btnAnalyzeAndSend);
            this.Controls.Add(this.btnAnalyzeAndShow);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.btnErrored3);
            this.Controls.Add(this.btnOk2);
            this.Controls.Add(this.btnErrored2);
            this.Controls.Add(this.btnOk1);
            this.Controls.Add(this.btnErrored);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.endPointTypeCmbBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddEndPoint);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEndpoint1);
            this.Name = "HealthConfig";
            this.Text = "Health Configuration";
            this.Load += new System.EventHandler(this.HealthConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEndpoint1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddEndPoint;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox endPointTypeCmbBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnErrored;
        private System.Windows.Forms.Button btnErrored2;
        private System.Windows.Forms.Button btnOk1;
        private System.Windows.Forms.Button btnErrored3;
        private System.Windows.Forms.Button btnOk2;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnAnalyzeAndShow;
        private System.Windows.Forms.Button btnAnalyzeAndSend;
        private System.Windows.Forms.FlowLayoutPanel verticalLayoutPanel;
    }
}