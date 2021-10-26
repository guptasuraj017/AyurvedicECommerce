using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyurvedicECommerce.Models.Product
{
    interface IProductRepositery
    {
        public IEnumerable<Product> GetProducts();
    }
}
