using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyurvedicECommerce.Models.Product
{
    public class MockProductRepositery : IProductRepositery
    {
        private List<Product> products;

        public Product GetProduct(int productId)
        {
            return products.FirstOrDefault(p => p.ProductId==productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            products = new List<Product>() 
            { 
              new Product{ProductId=101, Name="Patanjali Tulsi Ghanvati", Category="Ayurvedic Medicine",
                  SubCategory="Vati", MRP=110, Description="Patanjali Divya Tulsi Ghan Vati is very beneficial for " +
                  "the health and immunity of the body. This is helpful in fever, dengue, cold, and chicken guinea.",InStock=true,
              Benefits="Useful in asthma and bronchitis treats fever and flu.", Ingredients="Tulsi",
              HowToUse="1-2 tablets twice a day or as directed by the physician.",
               OtherProductInfo="Best before-24 months from manufacturing date.", ProductImagePath="400x300TulsiGhanVati.png", Seller="Patanjali"},
              new Product{ProductId=102, Name="Divya Eye Grit Gold", Category="Ayurvedic Medicine",
                  SubCategory="Vati", MRP=600, Description="Divya Eyegrit Gold is useful in eye weakness, eye inflammation, vision related problems.",
                  Benefits="General eye weakness, eye inflammation, vision related problem." ,
                  Ingredients="Powder of :" +
"Amla Extract Fr. 160 mg"+
"Gajar Extract Rt. 10 mg,",
              HowToUse="1-2 tablets twice a day or as directed by the physician.",
               OtherProductInfo="Best before 1080 days from manufacturing.", ProductImagePath="1633603837400x300EyeGritGold.jpg", Seller="Patanjali"}
            };
            return products;
        }
    }
}
