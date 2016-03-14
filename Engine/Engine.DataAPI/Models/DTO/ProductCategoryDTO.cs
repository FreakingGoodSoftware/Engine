using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Engine.DataAPI.Models.DTO
{
    public class ProductCategoryDTO
    {
        public int ProductCategoryID { get; set; }

        public int? ParentProductCategoryID { get; set; }

        public string Name { get; set; }

        public DateTime ModifiedDate { get; set; }

        public List<Product> Products { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}