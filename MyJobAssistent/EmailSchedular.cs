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
        AppHealthActionConfig _appHealthAction;
        public EmailSchedular()
        {
            InitializeComponent();
        }

        public EmailSchedular(AppHealthActionConfig appHealthAction)
        {
            _appHealthAction = appHealthAction;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Job Scheduled");
            this.Close();
        }
    }
}
