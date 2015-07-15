using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.MenuOfLinks
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.menu1.DataSource = this.FeedData();
            this.menu1.DataBind();
        }

        private IEnumerable<Item> FeedData()
        {
            var urls = new List<Item>{
                new Item("google","https://www.google.bg/"),
                new Item("facebook","https://www.facebook.com/"),
                new Item("yahoo","https://www.yahoo.com/"),
            };

            return urls;
        }
    }
}