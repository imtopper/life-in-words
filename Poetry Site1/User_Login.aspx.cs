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
    public partial class Login : System.Web.UI.Page
    {
        string str;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["topper"].ConnectionString);
        SqlCommand com;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Email_Id"] != null)
            {
                Response.Redirect("home.aspx");
            }
        }

        protected void Unnamed3_Click1(object sender, EventArgs e)
        {
            String email_address, password;
            con.Open();
            String cmd = "select Email_id,Confirmpassword from [Register] where Email_id='" + TextBox1.Text.ToString() + "' and Confirmpassword='" + MyEncrypt(TextBox2.Text).ToString() + "'";
            SqlCommand login = new SqlCommand(cmd, con);
            SqlDataReader read = login.ExecuteReader();
            if (read.Read())
            {
                email_address = read.GetValue(0).ToString().Trim();
                password = read.GetValue(1).ToString().Trim();
                Session["Email_id"] = email_address.ToString();
                Response.Redirect("~/User_Home/WelcomeNew1.aspx");


            }
            else
            {
                Label1.Text = "Incorrect Username or Password";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
        private string MyEncrypt(string returnText)
        {
            string EncryptionKey = "E6C69AC9CCE39";
            byte[] clearBytes = Encoding.Unicode.GetBytes(returnText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    returnText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return returnText;
        }
        private string MyDecrypt(string returnText)
        {
            string EncryptionKey = "E6C69AC9CCE39";
            byte[] cipherBytes = Convert.FromBase64String(returnText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    returnText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return returnText;
        }
    }
}


 

   
