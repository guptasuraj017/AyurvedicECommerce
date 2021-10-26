using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyurvedicECommerce.Models.Product
{
    public class MockProductRepositery : IProductRepositery
    {
        private List<Product> products;
        public IEnumerable<Product> GetProducts()
        {
            products = new List<Product>() 
            { 
              new Product{ProductId=101, Name="Pachak Sodhit Harad", Category="Natural Health Care",
                  SubCategory="Digestives", MRP=45, Description="Pachak Shodhit Harad is one of the " +
                  "many options in the Patanjali Natural Health care and Digestive products range helps " +
                  "soothe common stomach ailments and strengthen the digestive system", InStock=true,
              Benefits="Useful in indigestion & abdominal distention.", Ingredients="Kala Lavan (Unaqua Sodium Chloride)",
              HowToUse="2-3 tablets twice a day or as directed by the physician.",
               OtherProductInfo="Best before-12 months from manufacturing date.", ProductImagePath="", Seller="Patanjali"}
            };
            throw new NotImplementedException();
        }
    }
}
