using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03.DumpAllEvents
{
    public partial class DupmEvents : System.Web.UI.Page
    {
        private static string newLine = "<br/>";

        protected void changed(object sender, EventArgs e)
        {
            Response.Write("changed");
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit invoked" + "<br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init invoked" + "<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load invoked" + "<br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender invoked" + "<br/>");
        }

        protected void OnLoad(object sender, EventArgs e)
        {
            Response.Write("Page_Load invoked" + newLine);
        }

        protected void EventBtn_Click(object sender, EventArgs e)
        {
            Response.Write("Button clicked" + "<br/>");
        }

        protected void EventBtn_Unload(object sender, EventArgs e)
        {
            //Response.Write not responsive in this context
        }
    }
}