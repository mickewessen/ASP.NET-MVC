using RepDepInjAndPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepDepInjAndPartialView.Services
{
    public class ProductService : IProductService
    {

        private List<Product> _productList { get; set; }

        public ProductService()
        {
            _productList = new List<Product>()
            {
                new Product {Id = 1, Name = "Dell XPS 13 7390", Description = "Core i7 16GB 512GB SSD 13.3\"", ImageUrl = "https://dustinweb.azureedge.net/image/614199/400/320/dell-xps-13-7390-core-i7-16gb-512gb-ssd-133.jpg", Price = "13 999 kr"},
                new Product {Id = 2, Name = "Lenovo ThinkPad X1 Carbon G7", Description = "Core i5 8GB 256GB SSD 14\"", ImageUrl = "https://dustinweb.azureedge.net/image/547070/400/320/lenovo-thinkpad-x1-carbon-g7-core-i5-8gb-256gb-ssd-14.jpg", Price = "9 999kr"},
                new Product {Id = 3, Name = "Apple MacBook Pro med Touch Bar (2020)", Description = "Core i7 16GB 512GB SSD 13.3\"", ImageUrl = "https://dustinweb.azureedge.net/image/577775/400/320/apple-macbook-pro-med-touch-bar-2020-core-i7-16gb-512gb-ssd-133.jpg", Price = "21 499kr"},
                new Product {Id = 4, Name = "Dell Latitude 5410", Description = "Core i5 8GB 256GB SSD 14\"", ImageUrl = "https://dustinweb.azureedge.net/image/587242/400/320/dell-latitude-5410-core-i5-8gb-256gb-ssd-14.jpg", Price = "8 399kr"}
            };
        }

        public IEnumerable<Product> GetBestSellers()
        {
            return _productList;
        }

        public IEnumerable<Product> GetLatest()
        {
            return _productList;
        }

        public Product GetProduct(int id)
        {
            return _productList.FirstOrDefault(p => p.Id == id);
        }
    }
}
