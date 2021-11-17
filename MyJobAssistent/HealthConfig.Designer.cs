
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
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.btnAnalyzeAndShow = new System.Windows.Forms.Button();
            this.btnAnalyzeAndSend = new System.Windows.Forms.Button();
            this.verticalLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(662, 22);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(135, 36);
            this.btnSaveConfig.TabIndex = 16;
            this.btnSaveConfig.Text = "Save Configuration";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnAnalyzeAndShow
            // 
            this.btnAnalyzeAndShow.Location = new System.Drawing.Point(662, 79);
            this.btnAnalyzeAndShow.Name = "btnAnalyzeAndShow";
            this.btnAnalyzeAndShow.Size = new System.Drawing.Size(135, 36);
            this.btnAnalyzeAndShow.TabIndex = 17;
            this.btnAnalyzeAndShow.Text = "Analyze and Show";
            this.btnAnalyzeAndShow.UseVisualStyleBackColor = true;
            this.btnAnalyzeAndShow.Click += new System.EventHandler(this.btnAnalyzeAndShow_Click);
            // 
            // btnAnalyzeAndSend
            // 
            this.btnAnalyzeAndSend.Location = new System.Drawing.Point(662, 137);
            this.btnAnalyzeAndSend.Name = "btnAnalyzeAndSend";
            this.btnAnalyzeAndSend.Size = new System.Drawing.Size(135, 36);
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
            this.verticalLayoutPanel.Location = new System.Drawing.Point(14, 22);
            this.verticalLayoutPanel.Name = "verticalLayoutPanel";
            this.verticalLayoutPanel.Size = new System.Drawing.Size(642, 416);
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
            this.Name = "HealthConfig";
            this.Text = "Health Configuration";
            this.Load += new System.EventHandler(this.HealthConfig_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.Button btnAnalyzeAndShow;
        private System.Windows.Forms.Button btnAnalyzeAndSend;
        private System.Windows.Forms.FlowLayoutPanel verticalLayoutPanel;
    }
}