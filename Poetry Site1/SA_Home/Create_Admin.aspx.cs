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

namespace Poetry_Site1.SA_Home
{
    public partial class Create_Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["User_Id"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["topper"].ConnectionString);
            con.Open();
            string inscmd = "insert into Admin_Login(Admin_Name,Email_id,Contact,Department,Doj,Admin_UserID,Admin_Pwd,DateTime)values(@Admin_Name,@Email_id,@Contact,@Department,@Doj,@Admin_UserID,@Admin_Pwd,@DateTime)";
            SqlCommand insertuser = new SqlCommand(inscmd, con);
            insertuser.Parameters.AddWithValue("@Admin_Name", TextBox1.Text);
            insertuser.Parameters.AddWithValue("@Email_id", TextBox2.Text);
            insertuser.Parameters.AddWithValue("@Contact", TextBox3.Text);
            insertuser.Parameters.AddWithValue("@Department", TextBox4.Text);
            insertuser.Parameters.AddWithValue("@Doj", TextBox5.Text);
            insertuser.Parameters.AddWithValue("@Admin_UserID", TextBox6.Text);
            insertuser.Parameters.AddWithValue("@Admin_Pwd", TextBox7.Text);
            insertuser.Parameters.AddWithValue("@DateTime", DateTime.Now.ToString());

            try
            {
                insertuser.ExecuteNonQuery();
                con.Close();
                //SendingMail(TextBox2.Text, "lifeinwords4u@gmail.com", "MiniprojectLifeinwords", "You Are Registered", TextBox1.Text);


                //SendingMail(Textbox2.Text, "nslcomp@gmail.com", "Project@123!", " you are registered", Textbox1.Text);
                Response.Redirect("~/SA_Home/Create_Admin.aspx");
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", string.Format("alert('Data Saved Successfully');"), true);
            }
            catch (Exception er)
            {
                Response.Write("something going wrong" + er.Message + "");
            }
            finally
            {

            }
        }

    }
}