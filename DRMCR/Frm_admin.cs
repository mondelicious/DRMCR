﻿using System;
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
    public partial class Frm_admin : Form
    {
        public Frm_admin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_manageDB fdb = new Frm_manageDB();
            fdb.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Logistics flg = new Frm_Logistics();
            flg.ShowDialog();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_employee fem = new Frm_employee();
            fem.ShowDialog();
            Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_login flog = new Frm_login();
            flog.ShowDialog();
            Hide();
        }
    }
}
