//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProductCollection
//{
//    class ProductThree
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Quantity { get; set; }
//        public decimal Price { get; set; }
//        public string Category { get; set; }
//        public int OrderCount { get; set; }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var products = new List<Product>
//        {
//            new Product { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 1000 },
//            new Product { Id = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 200, Category = "Chairs", OrderCount = 4000 },
//            new Product { Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 },
//        };

//            // Display all properties
//            DisplayProperties(products);

//            // Display specific properties
//            DisplayProperties(products, new string[] { "Name", "Quantity", "OrderCount" });
//        }

//        private static void DisplayProperties(List<Product> products, string[] properties = null)
//        {
//            if (properties == null)
//            {
//                properties = typeof(Product).GetProperties().Select(p => p.Name).ToArray();
//            }

//            var query = from p in products
//                        select new
//                        {
//                            PropertyValues = properties.Select(property =>
//                                typeof(Product)
//                                    .GetProperty(property)
//                                    .GetValue(p))
//                                    .ToArray()
//                        };

//            foreach (var item in query)
//            {
//                foreach (var value in item.PropertyValues)
//                {
//                    Console.Write(value + " ");
//                }
//                Console.WriteLine();
//            }
//        }
//    }

//}
