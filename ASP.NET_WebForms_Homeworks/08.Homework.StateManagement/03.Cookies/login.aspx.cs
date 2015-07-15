using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03.Cookies
{
    public partial class login : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("logged", "RandomUser");
            cookie.Expires = DateTime.Now.AddSeconds(5);

            Response.Cookies.Add(cookie);
        }

        protected void redirect_btn_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["logged"];

            if (cookie == null)
            {
                Response.Write("You are not logged in!!!");
            }
            else
            {
                Response.Redirect("userLogged.aspx");
            }
        }
    }
}