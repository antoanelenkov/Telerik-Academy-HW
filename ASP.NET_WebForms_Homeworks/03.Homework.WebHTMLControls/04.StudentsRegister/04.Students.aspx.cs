using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01_03.ControlsContent
{
    public partial class _04_Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterStudent(object sender, EventArgs e)
        {
            var selectedCourses = new List<ListItem>();

            foreach (ListItem  item in this.CheckBoxListOfCourses.Items)
            {
                if (item.Selected)
                {
                    selectedCourses.Add(item);
                }
            }

            var sb=new StringBuilder();
            sb.AppendFormat("<span>First name: {0}</span></br>", Server.HtmlEncode(this.tbxFirstName.Text));
            sb.AppendFormat("<span>Last name: {0}</span></br>", Server.HtmlEncode(this.tbxLastName.Text));
            sb.AppendFormat("<span>Faculty number: {0}</span></br>", Server.HtmlEncode(this.tbxFN.Text));
            sb.AppendFormat("<span>University: {0}</span></br>", this.DropDownListOfUniv.SelectedItem.Value);
            sb.AppendFormat("<span>Specialty: {0}</span></br>", this.DropDownListOfSpec.SelectedItem.Value);
            sb.AppendFormat("<span>Courses:</span></br>");
            foreach (var item in selectedCourses)
            {
                sb.AppendFormat("<span>{0}</span></br>", item);
            }           

            this.result.InnerHtml = sb.ToString();
        }
    }
}