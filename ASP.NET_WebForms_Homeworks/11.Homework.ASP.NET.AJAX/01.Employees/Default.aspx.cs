using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.Employees
{
    public partial class Default : System.Web.UI.Page
    {
        private Dictionary<String, List<String>> custOrders;

        protected void Page_Load(object sender, EventArgs e)
        {
            DbSeed();

            if (!Page.IsPostBack)
            {
                this.employees_lbx.DataSource = custOrders.Select(x => x.Key);
                this.employees_lbx.DataBind();
            }
        }

        protected void employees_lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEmployee = this.employees_lbx.SelectedValue;

            Thread.Sleep(1000);

            this.orders_grid.DataSource = custOrders.FirstOrDefault(x => x.Key == selectedEmployee).Value;
            this.orders_grid.DataBind();
        }

        private void DbSeed()
        {
            string[] customers = new string[] { "Ivan", "Elena", "Georgi" };

            custOrders = new Dictionary<string, List<string>>();

            custOrders.Add(customers[0], new List<string> { "kiselo mlqko", "malko hleb", "zerzevat" });
            custOrders.Add(customers[1], new List<string> { "prqsno mleko", "lukanka", "salam" });
            custOrders.Add(customers[2], new List<string> { "popara", "mnogo hleb", "rakiq" });
        }
    }
}