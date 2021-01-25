using Microsoft.AspNetCore.Mvc;
using RepDepInjAndPartialView.Models;
using RepDepInjAndPartialView.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepDepInjAndPartialView.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var viewModel = new ProductsViewModel();
            viewModel.ProductsList = new List<ProductList>
            {
                new ProductList { Title = "Bestsellers", Items = _productService.GetBestSellers() },
                new ProductList { Title = "Latest", Items = _productService.GetLatest() }
            };

            return View(viewModel.ProductsList);
        }
    }
}
