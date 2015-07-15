using Continents.Repos;
using Contintents.Models.Tables;
using System;
using System.Collections.Generic;
//using Microsoft.AspNet.EntityDataSource;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet;
using System.Data.Entity.Infrastructure;
using Contintents.Models;
using System.Threading;

namespace _01.Continents
{
    public partial class WorldMap : System.Web.UI.Page
    {
        DBUnitOfWork dataSource;

        protected void Page_Load(object sender, EventArgs e)
        {
            GetDB();

            if (!Page.IsPostBack)
            {
                this.ListBox_continents.DataSource = dataSource.Continents.All().Select(x => x.Name).ToList();
                this.ListBox_continents.DataBind();
                this.Countries.Visible = false;
                this.Towns.Visible = false;
            }
        }

        private void GetDB()
        {
            var db = new DBWebContext();
            dataSource = new DBUnitOfWork(db);
        }

        #region Continents
        protected void ListBoxContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentContinent = this.ListBox_continents.Text;
            var countries = dataSource.Countries.All().Where(x => x.Continent.Name == currentContinent).Select(x => x.Name).ToList();

            this.ListBox_Countries.DataSource = countries;
            this.ListBox_Countries.DataBind();

            if (countries.Count != 0)
            {
                this.tbContinent.Text = currentContinent;
                this.Countries.Visible = true;
            }
            else
            {
                this.Countries.Visible = false;
            }

            this.Towns.Visible = false;
        }

        protected void InsertContienent_OnClick(object sender, EventArgs e)
        {
            var selectedContient = this.tbContinent.Text;

            this.dataSource.Continents.Add(new Continent { Name = selectedContient });
            this.dataSource.SaveChanges();
            this.ListBox_continents.DataSource = dataSource.Continents.All().Select(x => x.Name).ToList();
            this.ListBox_continents.DataBind();
        }

        protected void DeleteContienent_OnClick(object sender, EventArgs e)
        {
            var selectedContient = this.tbContinent.Text;

            if (this.dataSource.Continents.All().FirstOrDefault(x => x.Name == (selectedContient)) != null)
            {
                this.dataSource.Continents.Delete(this.dataSource.Continents.All()
                    .OrderByDescending(x => x.ContinentId)//delete the last matched element
                    .FirstOrDefault(x => x.Name == (selectedContient)));
                this.dataSource.SaveChanges();
                this.ListBox_continents.DataSource = dataSource.Continents.All().Select(x => x.Name).ToList();
                this.ListBox_continents.DataBind();
            }
            else
            {
                this.continentError.InnerText = "There is no such continent!";
            }
        }
        #endregion

        #region Countries
        protected void ListBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentCountry = this.ListBox_Countries.Text;

            if (this.ViewState["sorting"] == null)
            {
                this.GridView_Towns.DataSource = dataSource.Towns.All().Where(x => x.Country.Name == currentCountry).ToList();
                this.GridView_Towns.DataBind();
            }
            else if (this.ViewState["sorting"].ToString() == "population")
            {
                this.GridView_Towns.DataSource = dataSource.Towns.All().Where(x => x.Country.Name == currentCountry).OrderBy(x => x.Population).ToList();
                this.GridView_Towns.DataBind();
            }
            else if (this.ViewState["sorting"].ToString() == "name")
            {
                this.GridView_Towns.DataSource = dataSource.Towns.All().Where(x => x.Country.Name == currentCountry).OrderBy(x => x.Country.Name).ToList();
                this.GridView_Towns.DataBind();
            }

            Thread.Sleep(1000);

            this.Towns.Visible = true;
            this.tbCountry.Text = currentCountry;
        }

        protected void btnInsertCountry_Click(object sender, EventArgs e)
        {
            var selectedCountry = this.tbCountry.Text;
            var selectedContinent = this.ListBox_continents.Text;

            try
            {
                var currentContinentID = dataSource.Continents.All().FirstOrDefault(x => x.Name == selectedContinent).ContinentId;
                var newCountry = new Country { Name = selectedCountry, ContinentId = currentContinentID, population = 10000000 };
                this.dataSource.Countries.Add(newCountry);
                this.dataSource.SaveChanges();
            }
            catch (NullReferenceException)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Choose continent first!!!')", true);
            }

            this.ListBox_continents.DataSource = dataSource.Continents.All().Select(x => x.Name).ToList();
            this.ListBox_continents.DataBind();
            this.ListBox_Countries.DataSource = dataSource.Countries.All().Select(x => x.Name).ToList();
            this.ListBox_Countries.DataBind();

        }

        protected void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            var selectedCountry = this.tbCountry.Text;
            var currentCountry = dataSource.Countries.All().FirstOrDefault(x => x.Name == selectedCountry);

            if (currentCountry != null)
            {
                this.dataSource.Countries.Delete(this.dataSource.Countries.All().FirstOrDefault(x => x.CountryID == currentCountry.CountryID));
                this.dataSource.SaveChanges();
                this.ListBox_Countries.DataSource = dataSource.Countries.All().Select(x => x.Name).ToList();
                this.ListBox_Countries.DataBind();
            }
            else
            {
                string scriptMessage = string.Format("alert('{0}');", "There is no such continent");
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "MessageFromValidation", scriptMessage, true);             
            }
        }
        #endregion

        #region towns
        protected void SortTowns(object sender, GridViewSortEventArgs e)
        {
            var currentCountry = this.ListBox_Countries.Text;

            switch (e.SortExpression)
            {
                case "population":
                    this.GridView_Towns.DataSource = dataSource.Towns.All().Where(x => x.Country.Name == currentCountry).OrderBy(x => x.Population).ToList();
                    this.ViewState["sorting"] = "population";
                    break;
                case "name":
                    this.GridView_Towns.DataSource = dataSource.Towns.All().Where(x => x.Country.Name == currentCountry).OrderBy(x => x.Name).ToList();
                    this.ViewState["sorting"] = "name";
                    break;
                case "country":
                    this.GridView_Towns.DataSource = dataSource.Towns.All().Where(x => x.Country.Name == currentCountry).OrderBy(x => x.Country.Name).ToList();
                    this.ViewState["sorting"] = "country";
                    break;
                default:
                    break;
            }

            this.GridView_Towns.DataBind();
        }
        #endregion

    }
}