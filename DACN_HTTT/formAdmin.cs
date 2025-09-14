using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN_HTTT
{
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 f1=new Form1();
            f1.Show();
            this.Hide();
    
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {
           uC_Dashbord1.Visible = false;
            btnDoashbord.PerformClick();
        
        }

        private void btnDoashbord_Click(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible=true;
            uC_Dashbord1.BringToFront();
        }
      
    }
}
