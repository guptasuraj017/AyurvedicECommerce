using AyurvedicECommerce.Models.Product;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyurvedicECommerce.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepositery _productRepositery;
        public ProductController(IProductRepositery productRepositery)
        {
            _productRepositery = productRepositery;
        }
        public ViewResult GetProduct(int productId)
        {
            var product = _productRepositery.GetProduct(productId);
            return View(product);
        }
    }
}
