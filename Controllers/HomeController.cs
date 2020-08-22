using System.Collections.Generic;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers {
    public class HomeController : Controller {

        public async Task<ViewResult> Index () {

            // List<string> results = new List<string> ();

            // foreach (Product p in Product.GetProducts ()) {
            //     string name = p?.Name ?? "<No Name>";
            //     decimal? price = p?.Price ?? 0;
            //     string relatedName = p?.Related?.Name ?? "<None>";

            //     results.Add (string.Format (
            //         $"Name: {name}, Price: {price}, Related: {relatedName}"
            //     ));
            // }

            ShopingCart cart = new ShopingCart { Products = Product.GetProducts() };
            // decimal cartTotal = cart.TotalPrices();
            long? pageLength = await MyAsyncMethods.GetPageLength();
            return View("Index", new string[] { $"PageLength: ${pageLength}" });

            // Dictionary<string, Product> products = new Dictionary<string, Product> {
            //     ["Kayak"]      = new Product { Name = "Kayak",      Price = 275M },
            //     ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M },
            // };

            // return View (products.Keys);
        }

    }
}