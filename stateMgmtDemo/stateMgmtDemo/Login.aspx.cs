using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stateMgmtDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            if (Login1.UserName == "Digen" && Login1.Password == "D123")
            {
                Session["UserName"] = Login1.UserName;
                Session["PassWord"] = Login1.Password;
                Response.Redirect("EmployeeSearch.aspx");
            }
            else
            {
                Session["UserName"] = null;
                Session["PassWord"] = null;
            }
        }
    }
}