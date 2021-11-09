using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyurvedicECommerce.Models.Product
{
    public interface IProductRepositery
    {
        public IEnumerable<Product> GetProducts();
        public Product GetProduct(int productId);
    }
}
