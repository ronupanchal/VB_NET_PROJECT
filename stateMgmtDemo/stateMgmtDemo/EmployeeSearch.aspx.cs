using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stateMgmtDemo
{
    public partial class EmployeeSearch : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["UserName"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmployeeDB db = new EmployeeDB();
            GridView1.DataSource = db.GetEmployee();
            GridView1.DataBind();
        }
        protected void lknEmpName_Click(object sender, EventArgs e)
        {
            LinkButton lnkEmp = sender as LinkButton;
            Response.Redirect("ViewEmployee.aspx?empid=" + lnkEmp.CommandName);
        }
    }
}