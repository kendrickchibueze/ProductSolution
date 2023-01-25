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

            Utility.PrintColorMessage(ConsoleColor.Cyan, "All Properties:");

            elasticCollection.Print(allProperties);

            Console.WriteLine(); 


            while (true)
            {
                Utility.PrintColorMessage(ConsoleColor.Cyan, "Enter properties to filter by (comma separated) or 'q' to exit:\n");


                string? properties = Console.ReadLine();

                if (properties == "q")
                {
                    break;
                    
                }

                if (string.IsNullOrWhiteSpace(properties))
                {
                    Utility.PrintColorMessage(ConsoleColor.Red, "Invalid input, please enter a valid properties.\n");

                    continue;
                }
                string[] propertiesArray = properties.Split(',');

                List<string> validProperties = new List<string> { "Id", "Name", "Quantity", "Price", "Category", "OrderCount" };

                bool isValid = true;

                foreach (string property in propertiesArray)
                {
                    if (!validProperties.Contains(property.Trim()))
                    {
                        Utility.PrintColorMessage(ConsoleColor.Red, "Invalid property: " + property);

                        isValid = false;

                        break;
                    }
                }

                if (isValid)
                {
                    var filteredProperties = elasticCollection.Get(propertiesArray);

                    elasticCollection.Print(filteredProperties, propertiesArray);

                    
                }
                else
                {
                    Utility.PrintColorMessage(ConsoleColor.Red, "Could not filter properties, please check the properties you have entered.\n");
                }
            }




        }

    }
}
