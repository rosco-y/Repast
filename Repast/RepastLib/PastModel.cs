using System;

namespace RepastLib
{
        public class Categories
        {
                public long ID { get; set; }
                public string CatName { get; set; }

        }
        public class Sites
        {
                public long CatID { get; set; }
                public long ID { get; set; }
                public string SiteName { get; set; }
                public string Password { get; set; }
        }
}
