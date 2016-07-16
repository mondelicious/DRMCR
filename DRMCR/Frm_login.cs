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
    public partial class Frm_login : Form
    {
        MySqlConnection conn = new MySqlConnection();
        public Frm_login()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT Username, Password, UserType FROM tbl_account WHERE Username = @un AND Password = @pw AND UserType = @ut");
            conn.Open();
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("un", txt_un.Text);
            cmd.Parameters.AddWithValue("pw", txt_pw.Text);
            cmd.Parameters.AddWithValue("ut", cBoxUser.Text);
            MySqlDataReader reader = cmd.ExecuteReader();

            //int count = 0;
            //while (reader.Read())
            //{
            //    count = count + 1;
            //}
            if (reader.HasRows)
            {
                if (cBoxUser.Text == "Admin")
                {
                    MessageBox.Show("Welcome!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_admin fad = new Frm_admin();
                    fad.Show();
                    Hide();
                }
                else if (cBoxUser.Text == "User")
                {
                    MessageBox.Show("Welcome!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_employee femploy = new Frm_employee();
                    femploy.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Wrong Password or User Type!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
