using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_05.Northwind.Pages
{
    public partial class _05_Repeater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.RepeaterCustomers.DataSource = DataGenerator.GetData();
            this.RepeaterCustomers.DataBind();
        }
    }
}