using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace stateMgmtDemo
{
    public partial class ViewEmployee : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["empid"]))
            {
                int empid = Convert.ToInt32(Request.QueryString["empid"]);

                EmployeeDB db = new EmployeeDB();
                Employee emp = db.GetEmployee(empid);
                if (emp != null)
                {
                   // lblEmployeeName.Text = emp.EmpName;
                   // lblAddress.Text = emp.Address;
                   // lblSalary.Text = emp.Salary.ToString();
                    lblEmail.Text = emp.EmailAddress;
                }
            }
        }
    }
}