using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.SimpleASPXpage
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnGreet_Click(object sender, EventArgs e)
        {
            this.LblGreeting.Text = "Hello " + TbName.Text;
        }
    }
}