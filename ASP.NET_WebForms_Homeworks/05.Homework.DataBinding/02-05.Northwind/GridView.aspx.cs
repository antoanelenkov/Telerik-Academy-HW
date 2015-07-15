using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_05.Northwind
{
    public partial class _02_GridView : System.Web.UI.Page
    {
       protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                EmployeeGridView.DataSource = DataGenerator.GetData();
                EmployeeGridView.DataBind();
            }
        }

        protected void grdData_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            EmployeeGridView.PageIndex = e.NewPageIndex;
            EmployeeGridView.DataSource = DataGenerator.GetData();
            EmployeeGridView.DataBind();
        }

      
    }
}