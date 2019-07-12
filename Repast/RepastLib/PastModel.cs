using System;


namespace RepastLib
{
        public class Category
        {
                public long ID { get; set; }
                public string CatName { get; set; }

        }
        public class Site
        { 

                public long CatID { get; set; }
                public long ID { get; set; }
                public string SiteName { get; set; }
                public string Password { get; set; }
        }
}
