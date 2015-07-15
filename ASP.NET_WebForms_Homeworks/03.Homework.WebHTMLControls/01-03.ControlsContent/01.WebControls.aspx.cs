using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_03.ControlsContent
{
    public partial class _01_WebControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitBtn_ServerClick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            try {
                this.randomlyGeneratedNumber.InnerText = rnd.Next(int.Parse(this.lowerBound.Value), int.Parse(this.upperBound.Value)).ToString();
            }
            catch
            {
                this.randomlyGeneratedNumber.InnerText = "Invalid Input";
            }
        }
    }
}