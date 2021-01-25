using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartialViewDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewDemo.Controllers
{
    public class ProductsController : Controller
    {

        private readonly IProductService _productService;
        private readonly ILogger<ProductsController> log;

        public ProductsController(IProductService productService, ILogger<ProductsController> logger)
        {
            _productService = productService;
            log = logger;
        }

        public IActionResult Index()
        {
            return View(_productService.GetProducts());
        }
    }
}
