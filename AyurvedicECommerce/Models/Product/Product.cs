using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyurvedicECommerce.Models.Product
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductImagePath { get; set; }
        public string Seller { get; set; }
        public string Description { get; set; }
        public bool InStock { get; set; }
        public int MRP { get; set; }
        public string Benefits { get; set; }
        public string Ingredients { get; set; }
        public string HowToUse { get; set; }
        public string OtherProductInfo { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
    }
}
