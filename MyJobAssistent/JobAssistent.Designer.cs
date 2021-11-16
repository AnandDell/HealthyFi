
namespace MyJobAssistent
{
    partial class JobAssistent
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
            this.BtnHealthReporter = new System.Windows.Forms.Button();
            this.BtnJobSchedular = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.verticalLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // BtnHealthReporter
            // 
            this.BtnHealthReporter.Location = new System.Drawing.Point(684, 89);
            this.BtnHealthReporter.Name = "BtnHealthReporter";
            this.BtnHealthReporter.Size = new System.Drawing.Size(101, 36);
            this.BtnHealthReporter.TabIndex = 0;
            this.BtnHealthReporter.Text = "Health Config";
            this.BtnHealthReporter.UseVisualStyleBackColor = true;
            this.BtnHealthReporter.Click += new System.EventHandler(this.HealthReporter_Click);
            // 
            // BtnJobSchedular
            // 
            this.BtnJobSchedular.Location = new System.Drawing.Point(684, 150);
            this.BtnJobSchedular.Name = "BtnJobSchedular";
            this.BtnJobSchedular.Size = new System.Drawing.Size(104, 36);
            this.BtnJobSchedular.TabIndex = 1;
            this.BtnJobSchedular.Text = "Job Schedular";
            this.BtnJobSchedular.UseVisualStyleBackColor = true;
            this.BtnJobSchedular.Click += new System.EventHandler(this.JobSchedular_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(684, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 36);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // verticalLayoutPanel
            // 
            this.verticalLayoutPanel.AutoScroll = true;
            this.verticalLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verticalLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.verticalLayoutPanel.Location = new System.Drawing.Point(32, 28);
            this.verticalLayoutPanel.Name = "verticalLayoutPanel";
            this.verticalLayoutPanel.Size = new System.Drawing.Size(611, 385);
            this.verticalLayoutPanel.TabIndex = 3;
            // 
            // JobAssistent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.verticalLayoutPanel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.BtnJobSchedular);
            this.Controls.Add(this.BtnHealthReporter);
            this.Name = "JobAssistent";
            this.Text = "HealthyFI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnHealthReporter;
        private System.Windows.Forms.Button BtnJobSchedular;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel verticalLayoutPanel;
    }
}

