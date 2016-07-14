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
    public partial class Frm_viewEmployee : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public Frm_viewEmployee()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void loadtable()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            string query = "SELECT * FROM tbl_employee";
            cmd.CommandText = query;


            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Frm_viewEmployee_Load(object sender, EventArgs e)
        {
            loadtable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_employee femploy = new Frm_employee();
            femploy.Show();
            Dispose();
        }
    }
}
