using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.Session
{
    public partial class WebFoorm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.output_lbx.DataSource = this.Session["input"];
            this.output_lbx.DataBind();
        }

        //session timeout is in web.config
        protected void input_btn_Click(object sender, EventArgs e)
        {
            var text = this.input_txt.Text;

            if (this.Session["input"] == null)
            {
                this.Session["input"] = new List<string>();
            }

            var list = (List<string>)this.Session["input"];
            list.Add(text);
            this.Session["input"] = list;

            this.currentOutput_lbl.Text = text;
            this.output_lbx.DataSource = this.Session["input"];
            this.output_lbx.DataBind();
        }
    }
}