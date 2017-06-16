using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStore_2017.Models.Abstract;
using SportStore_2017.Models.Concrete;

namespace SportStore_2017.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository repository = new EFProductRepository();
        // GET: Nav
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = repository.Products.Select(x => x.Category)
                .Distinct().OrderBy(x => x);
            return PartialView(categories);
        }
    }
}