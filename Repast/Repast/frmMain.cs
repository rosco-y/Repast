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
                }

                private void CmdAddCategory_Click(object sender, EventArgs e)
                {
                        Category c = new Category();
                        c.CatName = txtCategoryName.Text;
                        sqliteDataAccess.AddCategory(c);
                        //_categories.Add(c);
                        loadCategorylist();
                        txtCategoryName.Text = "";
                }

                void loadCategorylist()
                {
                        _categories = sqliteDataAccess.LoadCategories();
                        wireUpListBoxes();
                }

                void wireUpListBoxes()
                {
                        // Categories
                        lstCategories.DataSource = null;
                        lstCategories.DataSource = _categories;
                        lstCategories.DisplayMember = "CatName";

                        // Sites
                        lstSites.DataSource = null;
                        lstSites.DataSource = _categories;
                        lstSites.DisplayMember = "SiteName";
                }

                private void CmdRefreshCategories_Click(object sender, EventArgs e)
                {
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

                                sqliteDataAccess.AddSite(cat.ID, s);
                                wireUpListBoxes();
                        }
                }

                //private void LstSites_SelectedIndexChanged(object sender, EventArgs e)
                //{
                //        if (lstSites.SelectedIndex >= 0)
                //        {
                //                Site S = (Site)lstSites.SelectedItem;

                //        }
                //}
        }
}
