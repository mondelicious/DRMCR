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
    public partial class Frm_employee : Form
    {
        public static string telNo = "";
        public static string servOrder = "";
        public static string tos = "";
        public static string timeStart = "";
        public static string timeEnd = "";
        public static string clrm = "";
        public static string okNo = "";
        public static string primCab = "";
        public static string secCab = "";
        public static string noSpan = "";
        public static string instruMod = "";
        public static string parallelWire = "";
        public static string jackWire = "";
        public static string protectPc = "";
        public static string pClamp = "";
        public static string groundRod = "";
        public static string groundWire = "";
        public static string connBlock = "";
        public static string splitter = "";
        public static string subsName = "";
        public static string address = "";
        public static string remarks = "";
        public static string mlrID = "";
        public static string id1 = "";
        public static string id2 = "";
        public static string bawa = "";
        public static string submitBy = "";
        public static string notedBy = "";
        public static string receivedBy = "";
        public Frm_employee()
        {
            InitializeComponent();
        }

        public void clear()
        {
            txt_telno.Text = null;
            txt_serviceord.Text = null;
            cBoxTos.Text = null;
            txt_timeStart.Text = null;
            txt_timeEnd.Text = null;
            txt_clrm.Text = null;
            txt_okNo.Text = null;
            txt_primeCab.Text = null;
            txt_secondCab.Text = null;
            txt_noSpan.Text = null;
            cBoxInstruModem.Text = null;
            txt_parallelWire.Text = null;
            txt_jacketWire.Text = null;
            txt_protector.Text = null;
            txt_pclamp.Text = null;
            txt_groundRod.Text = null;
            txt_groundWire.Text = null;
            txt_conblock.Text = null;
            txt_splitter.Text = null;
            txt_subsName.Text = null;
            txt_address.Text = null;
            txt_remarks.Text = null;
            txt_mlrID.Text = null;
            txt_id1.Text = null;
            txt_id2.Text = null;
            txt_bawa.Text = null;
            txt_submitBy.Text = null;
            txt_notedBy.Text = null;
            txt_receivedBy.Text = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save this information?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                telNo = txt_telno.Text;
                servOrder = txt_serviceord.Text;
                tos = cBoxTos.Text;
                timeStart = txt_timeStart.Text;
                timeEnd = txt_timeEnd.Text;
                clrm = txt_clrm.Text;
                okNo = txt_okNo.Text;
                primCab = txt_primeCab.Text;
                secCab = txt_secondCab.Text;
                noSpan = txt_noSpan.Text;
                instruMod = cBoxInstruModem.Text;
                parallelWire = txt_parallelWire.Text;
                jackWire = txt_jacketWire.Text;
                protectPc = txt_protector.Text;
                pClamp = txt_pclamp.Text;
                groundRod = txt_groundRod.Text;
                groundWire = txt_groundWire.Text;
                connBlock = txt_conblock.Text;
                splitter = txt_splitter.Text;
                subsName = txt_subsName.Text;
                address = txt_address.Text;
                remarks = txt_remarks.Text;
                mlrID = txt_mlrID.Text;
                id1 = txt_id1.Text;
                id2 = txt_id2.Text;
                bawa = txt_bawa.Text;
                submitBy = txt_submitBy.Text;
                notedBy = txt_notedBy.Text;
                receivedBy = txt_receivedBy.Text;
                Cls_cmd.insertEmployee();
                clear();
            }
            else
            {
                //TODO:NOTHING
            }
        }

        private void Frm_employee_Load(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Frm_login flogin = new Frm_login();
            flogin.Show();
            Dispose();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Frm_viewEmployee fview = new Frm_viewEmployee();
            fview.Show();
            Dispose();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txt_telno_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_telno.MaxLength = 7;
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("This textbox accepts only numerical.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txt_okNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("This textbox accepts only numerical.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_id1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("This textbox accepts only numerical.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_id2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("This textbox accepts only numerical.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_mlrID_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_mlrID.MaxLength = 6;
            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("This textbox accepts only numerical.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_serviceord_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_clrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("Please input letters.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_subsName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("Please input letters.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_subsName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_submitBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; base.OnKeyPress(e);
                MessageBox.Show("Please input letters.", "System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Frm_admin fadmin = new Frm_admin();
            fadmin.Show();
            Hide();
        }
    }
}
