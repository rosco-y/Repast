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
                public frmMain()
                {
                        _categories = new List<Category>();
                        InitializeComponent();
                        loadCategorylist();
                }

                private void CmdAddCategory_Click(object sender, EventArgs e)
                {
                        Category c = new Category();
                        c.CatName = txtCategoryName.Text;
                        sqliteDataAccess.AddCategory(c);
                        //_categories.Add(c);
                        wireUpCategories();
                        txtCategoryName.Text = "";
                }

                void loadCategorylist()
                {
                        _categories = sqliteDataAccess.LoadCategories();
                        wireUpCategories();
                }

                void wireUpCategories()
                {
                        lstCategories.DataSource = null;
                        lstCategories.DataSource = _categories;
                        lstCategories.DisplayMember = "CatName";
                }

                private void CmdRefreshCategories_Click(object sender, EventArgs e)
                {
                        wireUpCategories();
                }
        }
}
