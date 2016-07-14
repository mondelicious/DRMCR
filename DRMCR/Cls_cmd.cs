using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DRMCR
{
    class Cls_cmd
    {
        public static void insert()
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            string INSERT = "INSERT INTO tbl_account(Employee_ID,First_name,Last_name,Email,Username,Password,UserType,Contact_number,Position)VALUES(@EID,@fn,@ln,@el,@un,@pw,@ut,@cn,@pst)";
            cmd.Parameters.AddWithValue("EID", Frm_manage.EID);
            cmd.Parameters.AddWithValue("fn", Frm_manage.firstName);
            cmd.Parameters.AddWithValue("ln", Frm_manage.lastName);
            cmd.Parameters.AddWithValue("el", Frm_manage.email);
            cmd.Parameters.AddWithValue("un", Frm_manage.userName);
            cmd.Parameters.AddWithValue("pw", Frm_manage.passWord);
            cmd.Parameters.AddWithValue("ut", Frm_manage.userType);
            cmd.Parameters.AddWithValue("cn", Frm_manage.contactNumber);
            cmd.Parameters.AddWithValue("pst", Frm_manage.position);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registration complete!", "DRMCR System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            Frm_manage.EID = null;
            Frm_manage.firstName = null;
            Frm_manage.lastName = null;
            Frm_manage.email = null;
            Frm_manage.userName = null;
            Frm_manage.passWord = null;
            Frm_manage.userType = null;
            Frm_manage.contactNumber = null;
            Frm_manage.position = null;
        }

        public static void insertEmployee()
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();
            cmd.Connection = conn;
            string INSERT = "INSERT INTO tbl_employee(Telephone_number,Service_Order,Type_of_Service,timeStart,timeEnd,Clrm_dispatch,Ok_no,Primary_cable,Secondary_cable,No_of_Span,Instrument_Modem,Paralleled_wire,Jacketed_wire,Protector,P_clamp,Ground_rod,Ground_wire,Connecting_block,Splitter,Subscriber_name,Address,Remarks,Installer_technician,Immediate_supervisor,Csoz_supervisor,Customer_service_Operation_zone,Submitted_by,Noted_by,Received_by)VALUES(@telno,@servOrder,@typeofServ,@tStart,@tEnd,@clrm,@ok,@pri,@sec,@nos,@instruMode,@parallelWire,@jacketWire,@protect,@pClamp,@gRod,@gWire,@connBlock,@split,@subsName,@address,@remark,@install,@immedSup,@csoz,@custServ,@submitBy,@noteBy,@recBy)";

            cmd.Parameters.AddWithValue("telno", Frm_employee.telNo);
            cmd.Parameters.AddWithValue("servOrder", Frm_employee.servOrder);
            cmd.Parameters.AddWithValue("typeofServ", Frm_employee.tos);
            cmd.Parameters.AddWithValue("tStart", Frm_employee.timeStart);
            cmd.Parameters.AddWithValue("tEnd", Frm_employee.timeEnd);
            cmd.Parameters.AddWithValue("clrm", Frm_employee.clrm);
            cmd.Parameters.AddWithValue("ok", Frm_employee.okNo);
            cmd.Parameters.AddWithValue("pri", Frm_employee.primCab);
            cmd.Parameters.AddWithValue("sec", Frm_employee.secCab);
            cmd.Parameters.AddWithValue("nos", Frm_employee.noSpan);
            cmd.Parameters.AddWithValue("instruMode", Frm_employee.instruMod);
            cmd.Parameters.AddWithValue("parallelWire", Frm_employee.parallelWire);
            cmd.Parameters.AddWithValue("jacketWire", Frm_employee.jackWire);
            cmd.Parameters.AddWithValue("protect", Frm_employee.protectPc);
            cmd.Parameters.AddWithValue("pClamp", Frm_employee.pClamp);
            cmd.Parameters.AddWithValue("gRod", Frm_employee.groundRod);
            cmd.Parameters.AddWithValue("gWire", Frm_employee.groundWire);
            cmd.Parameters.AddWithValue("connBlock", Frm_employee.connBlock);
            cmd.Parameters.AddWithValue("split", Frm_employee.splitter);
            cmd.Parameters.AddWithValue("subsName", Frm_employee.subsName);
            cmd.Parameters.AddWithValue("address", Frm_employee.address);
            cmd.Parameters.AddWithValue("remark", Frm_employee.remarks);
            cmd.Parameters.AddWithValue("install", Frm_employee.mlrID);
            cmd.Parameters.AddWithValue("immedSup", Frm_employee.id1);
            cmd.Parameters.AddWithValue("csoz", Frm_employee.id2);
            cmd.Parameters.AddWithValue("custServ", Frm_employee.bawa);
            cmd.Parameters.AddWithValue("submitBy", Frm_employee.submitBy);
            cmd.Parameters.AddWithValue("noteBy", Frm_employee.notedBy);
            cmd.Parameters.AddWithValue("recBy", Frm_employee.receivedBy);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registration complete!", "DRMCR System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        public static void update()
        {
            MySqlCommand cmd = new MySqlCommand();

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            //update code goes here
            conn.Open();
            cmd.Connection = conn;
            string UPDATE = "UPDATE tbl_account SET First_name = @fn, Last_name = @ln, Email = @eAdd, Username = @un, Password = @pw, UserType = @ut, Contact_number = @cn, Position = @post WHERE Employee_ID = @eid";
            cmd.Parameters.AddWithValue("fn", Frm_manage.fn);
            cmd.Parameters.AddWithValue("ln", Frm_manage.ln);
            cmd.Parameters.AddWithValue("eAdd", Frm_manage.eAdd);
            cmd.Parameters.AddWithValue("un", Frm_manage.un);
            cmd.Parameters.AddWithValue("pw", Frm_manage.pw);
            cmd.Parameters.AddWithValue("ut", Frm_manage.ut);
            cmd.Parameters.AddWithValue("cn", Frm_manage.contactNum);
            cmd.Parameters.AddWithValue("post", Frm_manage.post);
            cmd.Parameters.AddWithValue("eid", Frm_manage.employID);
            cmd.CommandText = UPDATE;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Successfully updated!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }
    }
}
