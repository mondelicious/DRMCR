using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace DRMCR
{
    public partial class Frm_Logistics : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public Frm_Logistics()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void search()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_employee WHERE Telephone_number=@tel_no", conn);
            cmd.Parameters.AddWithValue("tel_no", txt_search.Text);
            cmd.CommandType = CommandType.Text;

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            conn.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Frm_login flog = new Frm_login();
            flog.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_manage fmanage = new Frm_manage();
            fmanage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cBoxSearchBy.Text == "TEL NO.")
            {
                search();
            }
        }
    }
}
