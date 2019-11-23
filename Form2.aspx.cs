using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Form2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LinkButton lnkBtnInsert = new LinkButton();
        lnkBtnInsert.Click += LnkBtnInsert_Click;
    }
    protected void LnkBtnInsert_Click(object sender, EventArgs e)
    {
        SqlDataSource1.InsertParameters["FirstName"].DefaultValue = 
            ((TextBox)GridView1.FooterRow.FindControl("txtFname")).Text;

        SqlDataSource1.InsertParameters["LastName"].DefaultValue =
            ((TextBox)GridView1.FooterRow.FindControl("txtLname")).Text;

        SqlDataSource1.InsertParameters["Gender"].DefaultValue =
            ((DropDownList)GridView1.FooterRow.FindControl("ddlGender")).SelectedValue;

        SqlDataSource1.InsertParameters["Salary"].DefaultValue =
            ((TextBox)GridView1.FooterRow.FindControl("txtSalary")).Text;

        SqlDataSource1.InsertParameters["DepartmentID"].DefaultValue =
            ((TextBox)GridView1.FooterRow.FindControl("txtDeptID")).Text;

        SqlDataSource1.Insert();
    }
}