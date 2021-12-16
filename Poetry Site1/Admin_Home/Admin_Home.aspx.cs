using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Poetry_Site1.Admin_Home
{
    public partial class Admin_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["Admin_UserID"].ToString();
        }
    }
}