using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
           {
               new Product()
               {
                   Name = "Iphone X",
                   Summary = "This phone is the company's biggest change to its flagship smartphone in years. ",
                   Description = "Lorem ipsum dolar sit amet",
                   ImageFile = "product-1.png",
                   Price = 950.00M,
                   Category = "Smart Phone"
               },
               new Product()
               {
                   Name = "LG G5",
                   Summary = "This phone is the company's biggest change to its flagship smartphone in years. ",
                   Description = "Lorem ipsum dolar sit amet",
                   ImageFile = "product-2.png",
                   Price = 750.00M,
                   Category = "Smart Phone"
               },
               new Product()
               {
                   Name = "Samsung S3",
                   Summary = "This phone is the company's biggest change to its flagship smartphone in years. ",
                   Description = "Lorem ipsum dolar sit amet",
                   ImageFile = "product-3.png",
                   Price = 1150.00M,
                   Category = "Smart Phone"
               },
               new Product()
               {
                   Name = "Samsung S8",
                   Summary = "This phone is the company's biggest change to its flagship smartphone in years. ",
                   Description = "Lorem ipsum dolar sit amet",
                   ImageFile = "product-4.png",
                   Price = 950.00M,
                   Category = "Smart Phone"
               },
               new Product()
               {
                   Name = "Iphone 3",
                   Summary = "This phone is the company's biggest change to its flagship smartphone in years. ",
                   Description = "Lorem ipsum dolar sit amet",
                   ImageFile = "product-5.png",
                   Price = 950.00M,
                   Category = "Smart Phone"
               },
               new Product()
               {
                   Name = "MacBook Pro",
                   Summary = "This phone is the company's biggest change to its flagship smartphone in years. ",
                   Description = "Lorem ipsum dolar sit amet",
                   ImageFile = "product-6.png",
                   Price = 1950.00M,
                   Category = "Computer"
               }
           };
        }
    }
}
