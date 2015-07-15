using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_03.ControlsContent
{
    public partial class _01_ServerControl : System.Web.UI.Page
    {
        Random rnd = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GenerateRandomNum(object sender, EventArgs e)
        {    
            int left,
                right;
            bool validLeftInput,
                validRightInput;

            validLeftInput= int.TryParse(txtLeft.Text,out left);
            validRightInput=int.TryParse(txtRight.Text,out right);

            if (left > right)
            {
                lblResult.Text = "</br>The upper bound cannot be less the the lower";
                return;
            }
            else if (validLeftInput == false || validLeftInput == false)
            {
                lblResult.Text = "</br>The input must be digit";
                return;
            }
            else
            {
                int result = rnd.Next(left, right);
                lblResult.Text = "</br>Result: " + result.ToString();
            }
        }
    }
}