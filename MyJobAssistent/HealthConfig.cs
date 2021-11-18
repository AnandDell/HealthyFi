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
        internal bool RefreshParent { get; private set; }
        public HealthConfig()
        {
            InitializeComponent();
            _apiService = new ApiService();
            RefreshParent = false;
        }

        private void BtnAddEndPoint_Click(object sender, EventArgs e)
        {
            verticalLayoutPanel.Controls.Add(GetHorizontalPanel(new AppHealthActionConfig { }, YLocation = YLocation + 50));
        }
        private async void BtnActionRow_Click(object sender, EventArgs e)
        {
            var currentEndPoint = ((sender as Control).Parent as FlowLayoutPanel).Controls.OfType<TextBox>().FirstOrDefault(x => x.Tag.ToString() == "EndPoint").Text;
            AppHealthActionConfig appHealthActionConfig = await _apiService.GetAppHealthActionConfig(currentEndPoint);

            if (appHealthActionConfig == null)
            {
                foreach (var horizontalLayoutControl in verticalLayoutPanel.Controls.OfType<FlowLayoutPanel>().ToList())
                {
                    if (horizontalLayoutControl.Controls.Count == 4)
                    {
                        appHealthActionConfig = GetAppHealthConfig(horizontalLayoutControl);
                        if (currentEndPoint == appHealthActionConfig.EndPoint)
                            break;
                        else
                            appHealthActionConfig = null;
                    }
                }
            }

            if (appHealthActionConfig != null)
            {
                using (JobSchedular jobSchedular = new JobSchedular(appHealthActionConfig))
                {
                    jobSchedular.ShowDialog();
                    appHealthActionConfig = jobSchedular.AppHealthAction;
                }
                await _apiService.UpdateHealthConfig(appHealthActionConfig);
            }
        }

        private async void HealthConfig_Load(object sender, EventArgs e)
        {
            YLocation = 20;
            List<AppHealthActionConfig> appHealthConfigs = await _apiService.GetAppHealthActionConfigList();

            verticalLayoutPanel.Controls.Clear();
            verticalLayoutPanel.SuspendLayout();
            verticalLayoutPanel.Controls.Add(GetHeaderPanel(YLocation));

            foreach (var appHealthConfig in appHealthConfigs)
            {
                verticalLayoutPanel.Controls.Add(GetHorizontalPanel(appHealthConfig, YLocation = YLocation + 50));
            }

            this.Controls.Add(verticalLayoutPanel);
        }

        private FlowLayoutPanel GetHorizontalPanel(AppHealthActionConfig appHealthConfig, int yLoc)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Name = appHealthConfig.EndpointName;
            panel.Size = new Size(635, 35);
            panel.Location = new Point(25, yLoc);
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.WrapContents = false;
            panel.Tag = appHealthConfig;

            TextBox txtEndPoint = new TextBox { Text = appHealthConfig.EndPoint, Size = new Size { Width = 370, Height = 24 }, Location = new Point(157, yLoc), Tag = "EndPoint" };
            //txtEndPoint.TextChanged += TxtEndPoint_TextChanged;
            panel.Controls.Add(txtEndPoint);

            ComboBox cmbApiType = new ComboBox { Size = new Size { Width = 100, Height = 24 }, Location = new Point(677, yLoc), Tag = "ApiType" };
            cmbApiType.Items.AddRange((new List<string> { "Web API", "Windows Service", "Wcf Service", "Remoting" }).ToArray());
            cmbApiType.Text = appHealthConfig.ApiType;
            panel.Controls.Add(cmbApiType);

            Button btnApiAction = new Button { Text = "Action", Location = new Point(797, yLoc), Margin = new Padding { Left = 10 } };
            btnApiAction.Tag = appHealthConfig;
            btnApiAction.Click += BtnActionRow_Click;
            panel.Controls.Add(btnApiAction);

            Button btnAddRow = new Button { Text = "+", Size = new Size { Width = 22, Height = 25 }, Location = new Point(847, yLoc), Margin = new Padding { Left = 10 } };           
            btnAddRow.Click += BtnAddEndPoint_Click;
            panel.Controls.Add(btnAddRow);

            return panel;
        }

        //private void TxtEndPoint_TextChanged(object sender, EventArgs e)
        //{
        //    ((sender as Control).Parent as FlowLayoutPanel).Controls.OfType<Button>().FirstOrDefault(x=>x.Text== "Action").Tag = (sender as Control).Text;
        //}

        private FlowLayoutPanel GetHeaderPanel(int yLocation)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Name = "Header";
            panel.Size = new Size(635, 35);
            panel.Location = new Point(25, yLocation);
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.WrapContents = false;

            Label lblEndPoint = new Label { Text = "Endpoint to Connect", Size = new Size { Width = 370, Height = 24 }, Location = new Point(157, yLocation) };
            panel.Controls.Add(lblEndPoint);

            Label lblApiType = new Label { Text = "Type", Size = new Size { Width = 100, Height = 24 }, Location = new Point(677, yLocation) };
            panel.Controls.Add(lblApiType);


            return panel;
        }

        private void btnAnalyzeAndShow_Click(object sender, EventArgs e)
        {
            RefreshParent = true;
            this.Close();
        }

        private async void btnAnalyzeAndSend_Click(object sender, EventArgs e)
        {
            EmailHelper.SendMail(await _apiService.GetHealthStatusList());

            MessageBox.Show("Email sent successfully.");

            this.Close();
        }

        private async void btnSaveConfig_Click(object sender, EventArgs e)
        {
            List<AppHealthActionConfig> appHealthConfigs = new List<AppHealthActionConfig>();
            var configs = await _apiService.GetAppHealthActionConfigList();
            foreach (var horizontalLayoutControl in verticalLayoutPanel.Controls.OfType<FlowLayoutPanel>().ToList())
            {
                if (horizontalLayoutControl.Controls.Count == 4)
                {
                    AppHealthActionConfig appHealthActionConfig = GetAppHealthConfig(horizontalLayoutControl);
                    var config = configs.FirstOrDefault(x => x.EndPoint == appHealthActionConfig.EndPoint);
                    if(config!=null)
                    {
                        appHealthActionConfig.ActionEndpoint = config.ActionEndpoint;
                        appHealthActionConfig.ActionEndpointType = config.ActionEndpointType;
                        appHealthActionConfig.IsTriggeredByDateTime = config.IsTriggeredByDateTime;
                        appHealthActionConfig.IsTriggeredByEmail = config.IsTriggeredByEmail;
                        appHealthActionConfig.IsTriggeredByNotification = config.IsTriggeredByNotification;
                        
                    }
                    appHealthConfigs.Add(appHealthActionConfig);
                }
            }
            await _apiService.SaveHealthConfigs(appHealthConfigs);

            MessageBox.Show("Configuration Saved");
        }

        private AppHealthActionConfig GetAppHealthConfig(FlowLayoutPanel horizontalLayoutControl)
        {
            AppHealthActionConfig appHealthActionConfig = new AppHealthActionConfig();
            foreach (var childControl in horizontalLayoutControl.Controls.OfType<Control>().ToList())
            {
                if (childControl.Text == "+")
                {
                    AppHealthActionConfig actionConfig = childControl.Tag as AppHealthActionConfig;
                    if (actionConfig != null)
                    {
                        appHealthActionConfig.ActionEndpoint = actionConfig.ActionEndpoint;
                        appHealthActionConfig.ActionEndpointType = actionConfig.ActionEndpointType;
                    }
                }
                else if (childControl.Tag.Equals("EndPoint"))
                {
                    appHealthActionConfig.EndPoint = appHealthActionConfig.EndpointName = childControl.Text;
                }
                else if (childControl.Tag.Equals("ApiType"))
                {
                    appHealthActionConfig.ApiType = childControl.Text;
                }
            }

            return appHealthActionConfig;
        }
    }
}
