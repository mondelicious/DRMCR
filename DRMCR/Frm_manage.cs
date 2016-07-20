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
    public partial class Frm_manage : Form
    {
        //registration var
        public static string EID = "";
        public static string firstName = "";
        public static string lastName = "";
        public static string email = "";
        public static string userName = "";
        public static string passWord = "";
        public static string userType = "";
        public static string contactNumber = "";
        public static string position = "";

        //update var
        public static string searchBox = "";
        public static string employID = "";
        public static string fn = "";
        public static string ln = "";
        public static string eAdd = "";
        public static string un = "";
        public static string pw = "";
        public static string ut = "";
        public static string contactNum = "";
        public static string post = "";

        MySqlConnection conn = new MySqlConnection();
        public Frm_manage()
        {
            InitializeComponent();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
        }

        public void clear()
        {
            txt_fn.Text = null;
            txt_ln.Text = null;
            txt_email.Text = null;
            txt_eid.Text = null;
            txt_un.Text = null;
            txt_pw.Text = null;
            cBoxUser.Text = null;
            txt_contact.Text = null;
            cBoxPosition.Text = null;

        }

        public void clearUpdate()
        {
            txt_search.Text = null;
            txt_firstname.Text = null;
            txt_lastname.Text = null;
            txt_eAdd.Text = null;
            txt_employID.Text = null;
            txt_username.Text = null;
            txt_password.Text = null;
            cBoxUsertype.Text = null;
            txt_contactNum.Text = null;
            cBoxPost.Text = null;

        }

        private void Frm_manage_Load(object sender, EventArgs e)
        {

        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save this information?", "DRMCR System", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                firstName = txt_fn.Text;
                lastName = txt_ln.Text;
                email = txt_email.Text;
                EID = txt_eid.Text;
                userName = txt_un.Text;
                passWord = txt_pw.Text;
                userType = cBoxUser.Text;
                contactNumber = txt_contact.Text;
                position = cBoxPosition.Text;
                Cls_cmd.insert();
                clear();
            }
            else
            {
                //TODO:NOTHING
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Frm_Logistics flogic = new Frm_Logistics();
            flogic.Show();
            Dispose();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            //used to load database data/record into the textbox without datagrid
            
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
          
        }
    

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
            
        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == string.Empty)
            {
                MessageBox.Show("Please fill-up the search box!", "System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Do you want to update this information?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    fn = txt_firstname.Text;
                    ln = txt_lastname.Text;
                    eAdd = txt_eAdd.Text;
                    employID = txt_employID.Text;
                    un = txt_username.Text;
                    pw = txt_password.Text;
                    ut = cBoxUsertype.Text;
                    contactNum = txt_contactNum.Text;
                    post = cBoxPost.Text;
                    Cls_cmd.update();
                    clearUpdate();
                }
                else
                {
                    //TODO: NOTHING
                }
            }
        }

        private void btn_bac_Click(object sender, EventArgs e)
        {
            Dispose();
            Frm_Logistics flogics = new Frm_Logistics();
            flogics.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_search.Text == string.Empty)
            {
                clearUpdate();
            }
            //used to load database data/record into the textbox without datagrid
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM db_pldt.tbl_account WHERE Employee_ID = @eid", conn);
            cmd.Parameters.AddWithValue("@eid", txt_search.Text);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader reader = cmd.ExecuteReader();

            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
                string gEmployID = reader.GetInt32(reader.GetOrdinal("Employee_ID")).ToString();
                string gfName = reader.GetString(reader.GetOrdinal("First_name"));
                string glName = reader.GetString(reader.GetOrdinal("Last_name"));
                string gEmail = reader.GetString(reader.GetOrdinal("Email"));
                string guserName = reader.GetString(reader.GetOrdinal("Username"));
                string gpassWord = reader.GetString(reader.GetOrdinal("Password"));
                string guType = reader.GetString(reader.GetOrdinal("UserType"));
                string gcontactNum = reader.GetString(reader.GetOrdinal("Contact_number"));
                string gpost = reader.GetString(reader.GetOrdinal("Position"));

                txt_firstname.Text = gfName;
                txt_lastname.Text = glName;
                txt_eAdd.Text = gEmail;
                txt_employID.Text = gEmployID;
                txt_username.Text = guserName;
                txt_password.Text = gpassWord;
                cBoxUsertype.Text = guType;
                txt_contactNum.Text = gcontactNum;
                cBoxPost.Text = gpost;
            }
            if (count == 0)
            {
                MessageBox.Show("No records found!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearUpdate();
            }
            else
            {
                //TODO:NOTHING
            }
            conn.Close();
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            clearUpdate();
        }

        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("Please enter number only.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_fn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("This textbox accepts only alphabetical characters.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txt_ln_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("This textbox accepts only alphabetical characters.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txt_contact_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("This textbox accepts only numerical.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("This textbox accepts only alphabetical characters.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("This textbox accepts only alphabetical characters.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_contactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("This textbox accepts only numerical.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
