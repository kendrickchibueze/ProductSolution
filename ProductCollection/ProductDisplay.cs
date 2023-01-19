using ProductLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCollection
{
    class ProductDisplay
    {

        public static void Run()
        {
            var products = new List<Product>
        {
            new Product { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 1000 },

            new Product { Id = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 200, Category = "Chairs", OrderCount = 4000 },

            new Product { Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 }
        };

            var elasticCollection = new ElasticProductCollection(products);


            var allProperties = elasticCollection.Get();

            Console.WriteLine("All Properties:");

            elasticCollection.Print(allProperties);

            Console.WriteLine();


            var specifiedProperties = elasticCollection.Get("Name", "Quantity", "OrderCount");

            elasticCollection.Print(specifiedProperties, "Name", "Quantity", "OrderCount");
        }

    }
}
