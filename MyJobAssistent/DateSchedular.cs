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
    public partial class DateSchedular : Form
    {
        AppHealthActionConfig _appHealthAction;
        public DateSchedular()
        {
            InitializeComponent();
        }

        public DateSchedular(bool reccurance)
        {
            InitializeComponent();
            checkBox1.Enabled = reccurance;
            checkBox2.Enabled = reccurance;
            checkBox3.Enabled = reccurance;

            this.Text = reccurance ? "Recurrance Schedular" : "Date Time Scheduler";
        }

        public DateSchedular(AppHealthActionConfig appHealthAction)
        {
            InitializeComponent();
            _appHealthAction = appHealthAction;
            checkBox1.Enabled = appHealthAction.Daily;
            checkBox2.Enabled = appHealthAction.Weekly;
            checkBox3.Enabled = appHealthAction.Monthly;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Job Scheduled");
            this.Close();
        }
    }
}
