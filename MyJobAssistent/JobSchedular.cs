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
        AppHealthActionConfig _appHealthAction;
        public JobSchedular()
        {
            InitializeComponent();
        }

        public JobSchedular(AppHealthActionConfig appHealthAction)
        {
            InitializeComponent();
            _appHealthAction = appHealthAction;
            txtEndPoint.Text = appHealthAction.EndPoint;
            txtJobEndPoint.Text = appHealthAction.ActionEndpoint;
            cmbBoxJobType.Text = appHealthAction.ActionEndpointType;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            DateSchedular schedular = new DateSchedular(true);
            schedular.ShowDialog();
        }

        private void btnRecurring_Click(object sender, EventArgs e)
        {
            DateSchedular schedular = new DateSchedular(true);
            schedular.ShowDialog();
        }

        private void btnEmailInitiator_Click(object sender, EventArgs e)
        {
            EmailSchedular schedular = new EmailSchedular();
            schedular.ShowDialog();
        }

        private void btnNotificationInititor_Click(object sender, EventArgs e)
        {
            NotificationSchedular schedular = new NotificationSchedular();
            schedular.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
