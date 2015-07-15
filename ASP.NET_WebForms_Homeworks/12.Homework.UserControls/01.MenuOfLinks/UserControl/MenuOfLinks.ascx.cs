using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace _01.MenuOfLinks
{
    public partial class MenuOfLinks : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.FontColor != null)
            {
                this.dataList.ForeColor = this.FontColor;
            }
        }
         
        public IEnumerable<Item> DataSource
        {
            get
            {
                return this.dataList.DataSource as IEnumerable<Item>;
            }
            set
            {
                this.dataList.DataSource = value;
            }
        }

        public Color FontColor { get; set; }
    }

}