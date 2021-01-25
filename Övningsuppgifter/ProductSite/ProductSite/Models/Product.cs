using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductSite.Models
{
    public class Product
    {
        public Product()
        {

        }

        public Product(string id, string productName, string description, double price, bool inStock)
        {
            Id = id;
            ProductName = productName;
            Description = description;
            Price = price;
            this.inStock = inStock;
        }

        public string Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool inStock { get; set; }

    }
}
