using System.Data.Entity;
using SportStore_2017.Models.Entities;

namespace SportStore_2017.DAL {
    public class EFDbContext :DbContext {
        public EFDbContext():base() {
          
        }

        public DbSet<Product> Products { get; set; }
    }
}