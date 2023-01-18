//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProductCollection
//{
//    class Product
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Quantity { get; set; }
//        public decimal Price { get; set; }
//        public string Category { get; set; }
//        public int OrderCount { get; set; }
//    }

//    class ExpandedProduct : Product
//    {
//        public void DisplayProperties(string[] properties = null)
//        {
//            if (properties == null)
//            {
//                properties = typeof(Product).GetProperties().Select(p => p.Name).ToArray();
//            }

//            foreach (var property in properties)
//            {
//                var propertyValue = typeof(Product).GetProperty(property).GetValue(this);
//                Console.Write(propertyValue + " ");
//            }
//            Console.WriteLine();
//        }
//    }

//    //class Program
//    //{
//    //    static void Main(string[] args)
//    //    {
//    //        var products = new List<ExpandedProduct>
//    //    {
//    //        new ExpandedProduct { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 1000 },
//    //        new ExpandedProduct { Id = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 200, Category = "Chairs", OrderCount = 4000 },
//    //        new ExpandedProduct { Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 },
//    //    };

//    //        // Display all properties
//    //        products[0].DisplayProperties();
//    //        products[1].DisplayProperties();
//    //        products[2].DisplayProperties();

//    //        // Display specific properties
//    //        products[0].DisplayProperties(new string[] { "Name", "Quantity", "OrderCount" });
//    //        products[1].DisplayProperties(new string[] { "Name", "Quantity", "OrderCount" });
//    //        products[2].DisplayProperties(new string[] { "Name", "Quantity", "OrderCount" });
//    //    }
//    //}

//}
