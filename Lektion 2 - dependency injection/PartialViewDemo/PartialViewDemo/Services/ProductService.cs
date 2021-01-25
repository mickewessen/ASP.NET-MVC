using PartialViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewDemo.Services
{
    public class ProductService : IProductService
    {
        private List<Product> _products;

        public ProductService()
        {
            _products = new List<Product>()
            {
                new Product("Product 1", 1000),
                new Product("Product 2", 2000),
                new Product("Product 3", 3000)
            };
        }

        public Product GetProduct(string id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }
    }
}
