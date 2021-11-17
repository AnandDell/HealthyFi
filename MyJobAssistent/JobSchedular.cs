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
        public JobSchedular()
        {
            InitializeComponent();
        }

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
        }

        private void btnEmailInitiator_Click(object sender, EventArgs e)
        {
            EmailSchedular schedular = new EmailSchedular(AppHealthAction);
            schedular.ShowDialog();
        }

        private void btnNotificationInititor_Click(object sender, EventArgs e)
        {
            NotificationSchedular schedular = new NotificationSchedular(AppHealthAction);
            schedular.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppHealthAction.ActionEndpoint = txtJobEndPoint.Text;
            AppHealthAction.ActionEndpointType = txtJobEndPoint.Text;
            MessageBox.Show("Job saved");
            this.Close();
        }
        
        private void btnExecute_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Job started");
            this.Close();
        }
    }
}
