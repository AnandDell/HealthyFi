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
    public partial class JobSchedular : Form
    {
        public AppHealthActionConfig AppHealthAction { get; private set; }
        ApiService _apiService = new ApiService();


        public JobSchedular(AppHealthActionConfig appHealthAction)
        {
            InitializeComponent();
            AppHealthAction = appHealthAction;
            txtEndPoint.Text = appHealthAction.EndPoint;
            txtJobEndPoint.Text = appHealthAction.ActionEndpoint;
            cmbBoxJobType.Text = appHealthAction.ActionEndpointType;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            DateSchedular schedular = new DateSchedular(AppHealthAction);
            schedular.ShowDialog();
            AppHealthAction.EndPoint = txtEndPoint.Text;
            AppHealthAction.ActionEndpoint = txtJobEndPoint.Text;
            AppHealthAction.ActionEndpointType = string.IsNullOrWhiteSpace(cmbBoxJobType.Text)? "Web API": cmbBoxJobType.Text;
            AppHealthAction.IsTriggeredByDateTime = true;
            AppHealthAction.IsTriggeredByEmail = false;
            AppHealthAction.IsTriggeredByNotification = false;
        }

        private void btnEmailInitiator_Click(object sender, EventArgs e)
        {
            EmailSchedular schedular = new EmailSchedular(AppHealthAction);
            schedular.ShowDialog();
            AppHealthAction.EndPoint = txtEndPoint.Text;
            AppHealthAction.ActionEndpoint = txtJobEndPoint.Text;
            AppHealthAction.ActionEndpointType = string.IsNullOrWhiteSpace(cmbBoxJobType.Text) ? "Web API" : cmbBoxJobType.Text;
            AppHealthAction.IsTriggeredByDateTime = false;
            AppHealthAction.IsTriggeredByEmail = true;
            AppHealthAction.IsTriggeredByNotification = false;
        }

        private void btnNotificationInititor_Click(object sender, EventArgs e)
        {
            NotificationSchedular schedular = new NotificationSchedular(AppHealthAction);
            schedular.ShowDialog();
            AppHealthAction.EndPoint = txtEndPoint.Text;
            AppHealthAction.ActionEndpoint = txtJobEndPoint.Text;
            AppHealthAction.ActionEndpointType = string.IsNullOrWhiteSpace(cmbBoxJobType.Text) ? "Web API" : cmbBoxJobType.Text;
            AppHealthAction.IsTriggeredByDateTime = false;
            AppHealthAction.IsTriggeredByEmail = false;
            AppHealthAction.IsTriggeredByNotification = true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            AppHealthAction.EndPoint = txtEndPoint.Text;
            AppHealthAction.ActionEndpoint = txtJobEndPoint.Text;
            AppHealthAction.ActionEndpointType = txtJobEndPoint.Text;
            await _apiService.UpdateHealthConfig(AppHealthAction);
            MessageBox.Show("Job saved");
            this.Close();
        }
    }
}
