using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.RegisterUser_ClientValidations
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            ScriptResourceDefinition jQuery = new ScriptResourceDefinition();
            jQuery.Path = "~/scripts/jquery-1.7.2.min.js";
            jQuery.DebugPath = "~/scripts/jquery-1.7.2.js";
            jQuery.CdnPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.7.2.min.js";
            jQuery.CdnDebugPath = "http://ajax.microsoft.com/ajax/jQuery/jquery-1.7.2.js";
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", jQuery);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            this.Page.Validate();
        }

        protected void CheckBoxRequired_AgreeWithRequirements(object sender, ServerValidateEventArgs e)
        {
            if (this.checkBox.Checked)
            {
                e.IsValid = true;
            }
            else
            {
                e.IsValid = false;
            }
        }
    }
}