using System.Collections;
using System.Collections.Generic;
using SportStore_2017.Models.Entities;

namespace SportStore_2017.Models.Abstract {
    public interface IProductRepository {
        IEnumerable<Product> Products { get; }
    }
}