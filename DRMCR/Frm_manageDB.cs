using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DRMCR
{
    public partial class Frm_manageDB : Form
    {
        public Frm_manageDB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;user=root;pwd=vans;database=db_pldt;";
                string file = "F:\\backup.sql";
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(file);
                            MessageBox.Show("Backup complete!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please check if the usb is present on the machine.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;user=root;pwd=vans;database=db_pldt;";
                string file = "F:\\backup.sql";
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(file);
                            MessageBox.Show("Restore complete!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please check if the usb is present on the machine.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
            Frm_login flogin = new Frm_login();
            flogin.Show();
        }
    }
}
