using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.MobileBG
{
    public partial class SearchModule : System.Web.UI.Page
    {
        private List<Producer> producers;
        private List<string> BMWModels;
        private List<string> mercedesModels;
        private List<string> audiModels;
        private List<string> engineTypes;
        private List<string> extras;
        private string selectedProducerName;


        protected void Page_Load(object sender, EventArgs e)
        {
            FillData();

            if (!Page.IsPostBack)
            {
                BindEngine();
                BindExtras();
                BindModels();
                GetModels(sender, e);
            }          
        }

        private void BindEngine()
        {
            this.RadioEngine.DataSource = engineTypes.Select(element => element);
            this.RadioEngine.SelectedValue = engineTypes[0];
            this.RadioEngine.DataBind();
        }

        private void BindExtras()
        {
            this.CheckExtras.DataSource = extras.Select(element => element);
            this.CheckExtras.DataBind();
        }

        private void BindModels()
        {
            this.DropProducer.DataSource = producers.Select(p => p.Name);
            this.DropProducer.DataBind();
        }

        protected void GetModels(object sender, EventArgs e)
        {
            selectedProducerName = this.DropProducer.SelectedValue;
            this.DropModels.DataSource = producers.FirstOrDefault(p => p.Name == selectedProducerName).Models;
            this.DropModels.DataBind();
        }

        protected void GetInfo(object sender, EventArgs e)
        {
            var sb = new StringBuilder();

            sb.AppendFormat("Producer: {0}<br>", this.DropProducer.SelectedValue);
            sb.AppendFormat("Model: {0}<br>", this.DropModels.SelectedValue);
            sb.AppendFormat("Engine: {0}<br>", this.RadioEngine.SelectedValue);
            sb.AppendFormat("Extras:<br>");
            foreach (ListItem extra in this.CheckExtras.Items)
            {
                if (extra.Selected)
                {
                    sb.AppendFormat("{0}<br>",extra);
                }
            }
            this.LitResult.Visible = true;
            this.LitResult.Text = sb.ToString();
        }

        private void FillData()
        {
            BMWModels = new List<string>{ "BMW 3", "BMW 4", "BMW 5", "BMW 6" };
            mercedesModels = new List<string> { "C class", "E class", "SLK", "S class" };
            audiModels = new List<string> { "A4", "A6", "A7", "A8" };
            engineTypes = new List<string> { "v4", "v6", "v8", "v12" };
            extras = new List<string> { "air conditioning", "servo", "alloy wheels" };


            producers = new List<Producer>{
                new Producer(){Name="BMW",Models=BMWModels},
                new Producer(){Name="Mercedes",Models=mercedesModels},
                new Producer(){Name="Audi",Models=audiModels}
            };


        }
    }
}