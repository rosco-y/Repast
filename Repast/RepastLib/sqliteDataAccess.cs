using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Data;
using Dapper;


namespace RepastLib
{
        public class sqliteDataAccess
        {
                #region CATEGORIES
                public static List<Category> LoadCategories()
                {
                        using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
                        {
                                var output = cnn.Query<Category>("select * from Categories", new DynamicParameters());
                                return output.ToList();
                        }
                }

                public static void AddCategory(Category c)
                {
                        using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
                        {
                                //string sql = $"Insert into Categories(CatName) values ({c.CatName});";
                                cnn.Execute("Insert into Categories(CatName) values (@CatName)", c);
                        }
                }
                #endregion
                private static string loadConnectionString(string id = "Default")
                {
                        return "Data Source=.\\REPAST.DB;Version=3; providerName = System.Data.SqlClient";
                }

                #region SITES
                public static List<Site> LoadSites()
                {
                        using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
                        {
                                var output = cnn.Query<Site>("select * from Sites", new DynamicParameters());
                                return output.ToList();
                        }
                }

                public static void AddSite(int CatID, Site s)
                {
                        using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
                        {
                                try
                                {
                                        string sql = $"Insert into Sites(CatID, SiteName, Password) values ({CatID}, \'{s.SiteName}\', \'{s.Password}\')";
                                        cnn.Execute(sql);
                                }
                                catch (SQLiteException x)
                                {
                                        throw x;
                                }
                               
                        }
                }             
                #endregion
        }
}
