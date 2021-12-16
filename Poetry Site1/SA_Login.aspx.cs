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
    public partial class SA_Login : System.Web.UI.Page
    {

        string str;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["topper"].ConnectionString);
        SqlCommand com;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User_Id"] != null)
            {
                Response.Redirect("home.aspx");
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            String email_address, password;
            con.Open();
            String cmd = "select User_Id,Password from [SA_Login] where User_Id='" + TextBox1.Text.ToString() + "' and Password='" + TextBox2.Text.ToString() + "'";
            SqlCommand login = new SqlCommand(cmd, con);
            SqlDataReader read = login.ExecuteReader();
            if (read.Read())
            {
                email_address = read.GetValue(0).ToString().Trim();
                password = read.GetValue(1).ToString().Trim();
                Session["User_Id"] = email_address.ToString();
                Response.Redirect("~/SA_Home/Create_Admin.aspx");


            }
            else
            {
                Label1.Text = "Incorrect Username or Password";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }


    }
}
    