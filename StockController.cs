using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Lagersaldo.Controllers
{
    public class StockController : Controller
    {
        private Repository _repo;
        private object p;
        private string productTitle;
        private IEnumerable<object> availableProducts;

        public StockController() : base()
        {
            _repo = new Repository();
        }

        public ActionResult Index(string productNr)
        {
            object availableProduct = _repo.GetAvailableStock();
            foreach (object p in availableProducts)
            {
                ;
            }

            var viewModel = new ProductsInStockViewModel() { availableProducts = new List<ProductStockDBO>() };
            {
                if (string.IsNullOrEmpty(productNr) || productTitle == productNr)
                {
                }
                else
                {
                    return View(viewModel);
                }
                viewModel.availableProducts.Add(NewMethod(p));
                return View(viewModel);
            }
            return View(viewModel);
        }

        private static ProductStockDBO NewMethod(object p)
        {
            return new ProductStockDBO()
            {
                ProductTitle = "Sandal",
                Quantity = "Quantity",
            };
        }
    }

    internal class ProductStockDBO
    {
        public object Quantity { get; set; }
        public object ProductNr { get; set; }
        public string ProductTitle { get; internal set; }
    }

    internal class ProductsInStockViewModel
    {
        public ProductsInStockViewModel()
        {
        }

        public List<ProductStockDBO> availableProducts { get; set; }
    }
}