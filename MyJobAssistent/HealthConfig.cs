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
        ApiService _apiService;
        int YLocation = 20;
        public HealthConfig()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private void BtnAddEndPoint_Click(object sender, EventArgs e)
        {
            verticalLayoutPanel.Controls.Add(GetHorizontalPanel(new AppHealthConfig { }, YLocation = YLocation + 50));
        }
        private void BtnActionRow_Click(object sender, EventArgs e)
        {
            JobSchedular jobSchedular = new JobSchedular();
            jobSchedular.ShowDialog();
        }

        private async void HealthConfig_Load(object sender, EventArgs e)
        {
            YLocation = 20;
            List<AppHealthConfig> appHealthConfigs = await _apiService.GetHealthStatus();

            verticalLayoutPanel.Controls.Clear();
            verticalLayoutPanel.SuspendLayout();
            verticalLayoutPanel.Controls.Add(GetHeaderPanel(YLocation));

            foreach (var appHealthConfig in appHealthConfigs)
            {
                verticalLayoutPanel.Controls.Add(GetHorizontalPanel(appHealthConfig, YLocation = YLocation + 50));
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

            TextBox txtEndPoint = new TextBox { Text = appHealthConfig.EndPoint, Size = new Size { Width = 350, Height = 24 }, Location = new Point(157, yLoc) };
            panel.Controls.Add(txtEndPoint);

            ComboBox cmbApiType = new ComboBox { Size = new Size { Width = 100, Height = 24 }, Location = new Point(657, yLoc) };
            cmbApiType.Items.AddRange((new List<string> { "Web API", "Windows Service", "Wcf Service", "Remoting" }).ToArray());            
            cmbApiType.Text = appHealthConfig.ApiType;
            panel.Controls.Add(cmbApiType);

            Button btnApiAction = new Button { Text="Action",  Location = new Point(807, yLoc), Margin = new Padding { Left = 20 } };
            btnApiAction.Click += BtnActionRow_Click;
            panel.Controls.Add(btnApiAction);

            Button btnAddRow = new Button { Text = "+", Size = new Size { Width = 22, Height = 25 }, Location = new Point(857, yLoc), Margin = new Padding { Left = 20 } };
            btnAddRow.Click += BtnAddEndPoint_Click;
            panel.Controls.Add(btnAddRow);

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

            Label lblEndPoint = new Label { Text = "Endpoint to Connect", Size = new Size { Width = 350, Height = 24 }, Location = new Point(157, yLocation) };
            panel.Controls.Add(lblEndPoint);

            Label lblApiType = new Label { Text = "Type", Size = new Size { Width = 100, Height = 24 }, Location = new Point(657, yLocation) };
            panel.Controls.Add(lblApiType);

           
            return panel;
        }

        private void btnAnalyzeAndShow_Click(object sender, EventArgs e)
        {
            //Call the confiured api
        }

        private void btnAnalyzeAndSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Analysis sent");
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Configuration Saved");
        }        
    }
}
