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
        public AppHealthActionConfig AppHealthAction { get; private set; }
        public DateSchedular()
        {
            InitializeComponent();
        }

        public DateSchedular(AppHealthActionConfig appHealthAction)
        {
            InitializeComponent();
            AppHealthAction = appHealthAction;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dateTimePicker1.Value = AppHealthAction.TimeToExecute;
            checkBox1.Enabled = AppHealthAction.Daily;
            checkBox2.Enabled = AppHealthAction.Weekly;
            checkBox3.Enabled = AppHealthAction.Monthly;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AppHealthAction.TimeToExecute = dateTimePicker1.Value;
            AppHealthAction.Daily = checkBox1.Enabled;
            AppHealthAction.Weekly = checkBox2.Enabled;
            AppHealthAction.Monthly = checkBox3.Enabled;
            MessageBox.Show("Job Scheduled");
            this.Close();
        }
    }
}
