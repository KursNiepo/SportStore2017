using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportStore_2017.Models;
using SportStore_2017.Models.Abstract;
using SportStore_2017.Models.Concrete;

namespace SportStore_2017.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository = new EFProductRepository();

        public int PageSize = 4;
        // GET: Product
        public ViewResult List(int page = 1) {
            ProductsListViewModel model = new ProductsListViewModel() {
                Products = repository.Products.OrderBy(p => p.ProductID)
                    .Skip((page - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo() {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    Totalitems = repository.Products.Count()
                }
            };
            return View(model);


        }
    }
}