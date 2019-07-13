using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepastLib;

namespace Repast
{
        public partial class frmMain : Form
        {
                List<Category> _categories;
                List<Site> _sites;
                public frmMain()
                {
                        _categories = new List<Category>();
                        _sites = new List<Site>();
                        InitializeComponent();
                        loadCategorylist();
                        loadSitesList();
                }

                #region CATEGORIES
                private void CmdAddCategory_Click(object sender, EventArgs e)
                {
                        Category c = new Category();
                        c.CatName = txtCategoryName.Text;
                        sqliteDataAccess.AddCategory(c);
                        _categories.Add(c);
                        loadCategorylist();
                        txtCategoryName.Text = "";
                }

                void loadCategorylist()
                {
                        _categories = sqliteDataAccess.LoadCategories();
                        wireUpListBoxes();
                }
                #endregion

                void wireUpListBoxes()
                {
                        // Categories
                        lstCategories.DataSource = null;
                        lstCategories.DataSource = _categories;
                        lstCategories.DisplayMember = "CatName";

                        // Sites
                        lstSites.DataSource = null;
                        lstSites.DataSource = _sites;
                        lstSites.DisplayMember = "SiteName";
                }

                #region SITES
                private void LstSites_SelectedIndexChanged(object sender, EventArgs e)
                {
                        if (lstSites.SelectedIndex >= 0)
                        {
                                Site S = (Site)lstSites.SelectedItem;

                        }
                }

                void loadSitesList()
                {
                        _sites = sqliteDataAccess.LoadSites();
                        wireUpListBoxes();
                }
                private void CmdAddSite_Click(object sender, EventArgs e)
                {

                        if (lstCategories.SelectedIndex >= 0)
                        {
                                Category cat = (Category)lstCategories.SelectedItem;

                                Site s = new Site();
                                s.SiteName = txtSiteName.Text;
                                s.Password = txtPassword.Text;
                                _sites.Add(s);
                                try
                                {
                                        sqliteDataAccess.AddSite(cat.ID, s);
                                }
                                catch (Exception x)
                                {
                                        MessageBox.Show($"Sqlite Error: {x.Message}");
                                }
                                sqliteDataAccess.AddSite(cat.ID, s);
                                wireUpListBoxes();
                        }
                }
                #endregion


                #region cmdBUTTONS
                private void CmdOpenPasswordGenerator_Click(object sender, EventArgs e)
                {
                        frmPasswordGenerator frmGen = new frmPasswordGenerator();

                        frmGen.ShowDialog();
                }

                private void CmdClose_Click(object sender, EventArgs e)
                {
                        this.Close();
                }

                #endregion
        }
}
