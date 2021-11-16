using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyJobAssistent
{
    public partial class HealthConfig : Form
    {
        bool OkBtnVisibility = false;
        ApiService _apiService;
        public HealthConfig()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private void btnAddEndPoint_Click(object sender, EventArgs e)
        {

        }

        private async void HealthConfig_Load(object sender, EventArgs e)
        {
            var yLoc = 20;
            List<AppHealthConfig> appHealthConfigs = await _apiService.GetHealthStatus();

            verticalLayoutPanel.Controls.Clear();
            verticalLayoutPanel.SuspendLayout();
            verticalLayoutPanel.Controls.Add(GetHeaderPanel(yLoc));

            foreach (var appHealthConfig in appHealthConfigs)
            {
                verticalLayoutPanel.Controls.Add(GetHorizontalPanel(appHealthConfig, yLoc = yLoc + 50));
            }

            this.Controls.Add(verticalLayoutPanel);
        }

        private FlowLayoutPanel GetHorizontalPanel(AppHealthConfig appHealthConfig, int yLoc)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Name = appHealthConfig.EndpointName;
            panel.Size = new Size(635, 35);
            panel.Location = new Point(25, yLoc);
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.WrapContents = false;

            Label lblEndPoint = new Label { Text = appHealthConfig.EndPoint, Size = new Size { Width = 450, Height = 24 }, Location = new Point(157, yLoc) };
            panel.Controls.Add(lblEndPoint);

            Label lblApiType = new Label { Text = appHealthConfig.ApiType, Size = new Size { Width = 50, Height = 24 }, Location = new Point(757, yLoc) };
            panel.Controls.Add(lblApiType);

            Label lblApiStatus = new Label { BackColor = appHealthConfig.BackColor, Size = new Size { Width = 12, Height = 12 }, Location = new Point(857, yLoc), Margin = new Padding { Left = 20 } };
            panel.Controls.Add(lblApiStatus);
            return panel;
        }
        private FlowLayoutPanel GetHeaderPanel(int yLocation)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Name = "Header";
            panel.Size = new Size(635, 35);
            panel.Location = new Point(25, yLocation);
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.WrapContents = false;

            Label lblEndPoint = new Label { Text = "Endpoint to Connect", Size = new Size { Width = 450, Height = 24 }, Location = new Point(157, yLocation) };
            panel.Controls.Add(lblEndPoint);

            Label lblApiType = new Label { Text = "Type", Size = new Size { Width = 50, Height = 24 }, Location = new Point(757, yLocation) };
            panel.Controls.Add(lblApiType);

           
            return panel;
        }

        private void btnAnalyzeAndShow_Click(object sender, EventArgs e)
        {
            ToggleButtons();
            //Call the confiured api
        }

        private void btnAnalyzeAndSend_Click(object sender, EventArgs e)
        {
            ToggleButtons();
            MessageBox.Show("Analysis sent");
        }

        private void ToggleButtons()
        {
            btnOk.Visible = OkBtnVisibility;
            btnOk1.Visible = OkBtnVisibility;
            btnOk2.Visible = OkBtnVisibility;
            btnErrored.Visible = !OkBtnVisibility;
            btnErrored2.Visible = !OkBtnVisibility;
            btnErrored3.Visible = !OkBtnVisibility;
            OkBtnVisibility = !OkBtnVisibility;
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Configuration Saved");
        }

        
    }
}
