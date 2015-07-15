using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_03.ControlsContent
{
    public partial class _03_Escaping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EscapeText(object sender, EventArgs e)
        {
            var escapedContent = Server.HtmlEncode(this.txtInput.Text);
            this.lblResult.Text = "</br>" + escapedContent;
        }
    }
}