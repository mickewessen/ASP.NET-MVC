using PartialViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewDemo.Services
{
    public interface IProductService
    {
        Product GetProduct(string id);
        IEnumerable<Product> GetProducts();
    }
}
