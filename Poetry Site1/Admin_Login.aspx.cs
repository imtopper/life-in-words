using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;


namespace Poetry_Site1
{
    public partial class Admin_Login : System.Web.UI.Page
    {
        string str;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["topper"].ConnectionString);
        SqlCommand com;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Admin_UserID"] != null)
            {
                Response.Redirect("home.aspx");
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            String email_address, password;
            con.Open();
            String cmd = "select Admin_UserID,Admin_Pwd from [Admin_Login] where Admin_UserID='" + TextBox1.Text.ToString() + "' and Admin_Pwd='" + TextBox2.Text.ToString() + "'";
            SqlCommand login = new SqlCommand(cmd, con);
            SqlDataReader read = login.ExecuteReader();
            if (read.Read())
            {
                email_address = read.GetValue(0).ToString().Trim();
                password = read.GetValue(1).ToString().Trim();
                Session["Admin_UserID"] = email_address.ToString();
                Response.Redirect("~/Admin_Home/Admin_Home.aspx");


            }
            else
            {
                Label1.Text = "Incorrect Username or Password";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }


    }
}
    