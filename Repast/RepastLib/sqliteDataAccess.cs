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
                                string sql = $"Insert into Categories(CatName) values ({c.CatName});";
                                cnn.Execute(sql);
                        }
                }

                private static string loadConnectionString(string id = "Default")
                {
                        return "Data Source=.\\REPAST.DB;Version=3; providerName = System.Data.SqlClient";
                }
        }
}
