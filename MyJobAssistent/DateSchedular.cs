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

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Job Scheduled");
            this.Close();
        }
    }
}
