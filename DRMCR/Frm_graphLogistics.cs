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
    public partial class Frm_graphLogistics : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        public Frm_graphLogistics()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM tbl_employee";
            MySqlDataReader reader;

            conn.Open();
            reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                this.chart1.Series["Total service rendered per month"].Points.AddXY(reader.GetString("Subscriber_name"), reader.GetString("Date_assign"));
            }
            conn.Close();
        }
    }
}
