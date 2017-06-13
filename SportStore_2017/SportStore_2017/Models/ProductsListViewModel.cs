using System.Collections.Generic;
using SportStore_2017.Models.Entities;

namespace SportStore_2017.Models {
    public class ProductsListViewModel {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}