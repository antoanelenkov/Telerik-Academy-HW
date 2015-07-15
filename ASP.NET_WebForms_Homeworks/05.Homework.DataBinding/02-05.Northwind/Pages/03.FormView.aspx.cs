using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_05.Northwind
{
    public partial class _03_DetailView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.FormView_Customers.DataSource = DataGenerator.GetData();
            this.DataBind();
        }

        protected void FormViewEmployees_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            this.FormView_Customers.PageIndex = e.NewPageIndex;
            this.FormView_Customers.DataSource = DataGenerator.GetData();
            this.FormView_Customers.DataBind();
        }
    }
}