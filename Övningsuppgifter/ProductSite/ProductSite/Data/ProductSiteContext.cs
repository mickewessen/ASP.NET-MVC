using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductSite.Models;

namespace ProductSite.Data
{
    public class ProductSiteContext : DbContext
    {
        public ProductSiteContext (DbContextOptions<ProductSiteContext> options)
            : base(options)
        {
        }

        public DbSet<ProductSite.Models.Product> Product { get; set; }
    }
}
