using System;


namespace RepastLib
{
        public class Category
        {
                public int ID { get; set; }
                public string CatName { get; set; }

        }
        public class Site
        { 

                public int CatID { get; set; }
                public int ID { get; set; }
                public string SiteName { get; set; }
                public string Password { get; set; }
        }
}
