using System.Data.Entity;
using SportStore_2017.Models.Entities;

namespace SportStore_2017.DAL {
    public class EFDbContextInitializer:DropCreateDatabaseIfModelChanges<EFDbContext> {
        protected override void Seed(EFDbContext context) {
            base.Seed(context);
            context.Products.Add(
                new Product() {
                    Name = "Piłka nożna",Category = "piłka nożna",Price = 23.69m,
                    Description = "To jest standardowa piłka zalecana przez FIFA"
                });
            context.Products.Add(
                new Product()
                {
                    Name = "Buty piłkarskie",
                    Category = "piłka nożna",
                    Price = 223.99m,
                    Description = "Bardzo wygodne buty PUMA same grają"
                });
            context.Products.Add(
                new Product()
                {
                    Name = "Koszulka piłkarska kolor Biały",
                    Category = "piłka nożna",
                    Price = 19.69m,
                    Description = "Koszulka z numerem 11 w barwach Realu"
                });
            context.Products.Add(
                new Product()
                {
                    Name = "Szachownica",
                    Category = "Szachy",
                    Price = 35.00m,
                    Description = "Rodzinna szachownica dużych rozmiarów"
                });
            context.Products.Add(
                new Product()
                {
                    Name = "Zegar szachowy",
                    Category = "Szachy",
                    Price = 19.99m,
                    Description = "Bardzo dokładny zegar szachowy turniejowy"
                });
            context.Products.Add(
                new Product()
                {
                    Name = "Złote figury szachowe",
                    Category = "Szachy",
                    Price = 233.49m,
                    Description = "Figury szachowe pozłacane o wielkości 50 cm"
                });
            context.Products.Add(
                new Product()
                {
                    Name = "Kajak",
                    Category = "Sporty wodne",
                    Price = 190m,
                    Description = "Jednoosobowa łódka bardzo zwrotna"
                });
            context.Products.Add(
                new Product()
                {
                    Name = "Czepek do pływania",
                    Category = "Sporty wodne",
                    Price = 9.99m,
                    Description = "Wygodny czepek do pływania w różnych kolorach"
                });
            context.Products.Add(
                new Product()
                {
                    Name = "Rower górski maly",
                    Category = "Kolarstwo",
                    Price = 423.00m,
                    Description = "Niewielki bardzo wytzymały rower górski"
                });
            context.Products.Add(
                new Product()
                {
                    Name = "Pompka rowerowa",
                    Category = "Kolarstwo",
                    Price = 12.69m,
                    Description = "Mała składana pompka rowerowa"
                });
            context.SaveChanges();
        }
    }
}