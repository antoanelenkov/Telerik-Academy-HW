using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_05.Northwind.Pages
{
    public partial class _03_ListView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var customers = DataGenerator.GetData();

            this.ListViewEmployees.DataSource = customers;
            this.DataBind();
        }
    }
}