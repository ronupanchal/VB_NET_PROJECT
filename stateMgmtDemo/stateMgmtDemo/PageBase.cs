using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace stateMgmtDemo
{
    public class PageBase : Page
    {
        protected override void OnInit(EventArgs e)
        {
            if (Session["UserName"] == null && Session["PassWord"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}