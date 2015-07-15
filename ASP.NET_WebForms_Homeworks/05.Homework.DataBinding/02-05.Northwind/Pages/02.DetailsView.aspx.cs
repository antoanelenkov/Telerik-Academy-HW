using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02_05.Northwind
{
    public partial class _02_DetailsView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var firstName = Request.QueryString["FirstName"];
            var customers = DataGenerator.GetData().Where(cust => cust.FirstName == firstName).ToList();

            this.DtlsViewCustomers.DataSource = customers;
            this.DataBind();
        }
    }
}