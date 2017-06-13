using System.Collections.Generic;
using SportStore_2017.Models.Abstract;
using SportStore_2017.Models.Entities;

namespace SportStore_2017.Models.Concrete {
    public class FakeProductRepository :IProductRepository {
        public FakeProductRepository() {
            Products = new List<Product>() {
                new Product() {Name = "Piłka nożna",Price = 25},
                new Product() {Name = "Rower górski",Price = 356.89m},
                new Product() {Name = "Buty sportowe PUMA",Price = 245.69m}
            };
        }
        public IEnumerable<Product> Products { get; }
    }
}