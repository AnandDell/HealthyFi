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
    public partial class EmailSchedular : Form
    {
        public AppHealthActionConfig AppHealthAction { get; private set; }
        public EmailSchedular()
        {
            InitializeComponent();
        }

        public EmailSchedular(AppHealthActionConfig appHealthAction)
        {
            AppHealthAction = appHealthAction;
            InitializeComponent();
            txtEmailBody.Text = AppHealthAction.EmailBody;
            txtEmailSubject.Text = AppHealthAction.EmailSubject;
            txtFromEmail.Text = AppHealthAction.TriggerFromEmailAddresses;
            txtToEmail.Text = AppHealthAction.TriggerToEmailAddress;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppHealthAction.EmailBody = txtEmailBody.Text;
            AppHealthAction.EmailSubject = txtEmailSubject.Text;
            AppHealthAction.IsTriggeredByEmail = true;
            AppHealthAction.TriggerFromEmailAddresses = txtFromEmail.Text;
            AppHealthAction.TriggerToEmailAddress = txtToEmail.Text;
            MessageBox.Show("Job Scheduled");
            this.Close();
        }
    }
}
