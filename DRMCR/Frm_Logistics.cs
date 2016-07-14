using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRMCR
{
    public partial class Frm_Logistics : Form
    {
        public Frm_Logistics()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_login flog = new Frm_login();
            flog.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_manage fmanage = new Frm_manage();
            fmanage.Show();
            this.Hide();
        }
    }
}
