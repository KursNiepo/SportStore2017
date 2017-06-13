using System.Collections.Generic;
using SportStore_2017.Models.Abstract;
using SportStore_2017.Models.Entities;
using SportStore_2017.DAL;

namespace SportStore_2017.Models.Concrete {
    public class EFProductRepository:IProductRepository {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products {
            get {
                return context.Products;
            }
        }
    }
}