//using System;
//using System.Collections.Generic;
//using System.Dynamic;
//using System.Linq;
//using System.Runtime.Intrinsics.X86;
//using System.Text;
//using System.Threading.Tasks;
//using static ProductCollection.withcomment;

//namespace ProductCollection
//{
//    internal class withcomment
//    {


//        public class Product
//        {
//            public int Id { get; set; }
//            public string Name { get; set; }
//            public int Quantity { get; set; }
//            public decimal Price { get; set; }
//            public string Category { get; set; }
//            public int OrderCount { get; set; }
//        }

//        public class ElasticCollection<T> : List<ExpandoObject>
//        {
//            public ElasticCollection(IEnumerable<T> source, params string[] properties)
//            {
//                // Use reflection to get the properties of the source object
//                var sourceProperties = typeof(T).GetProperties();

//                // If no properties are specified, add all the properties of the source object
//                if (properties.Length == 0)
//                {
//                    properties = sourceProperties.Select(p => p.Name).ToArray();
//                }

//                // Use LINQ to select the specified properties from the source object
//                // and add them as dynamic properties to the ExpandoObject
//                foreach (var item in source)
//                {
//                    var expando = new ExpandoObject();
//                    var expandoDict = expando as IDictionary<string, object>;

//                    foreach (var property in properties)
//                    {
//                        var sourceProperty = sourceProperties.SingleOrDefault(p => p.Name == property);
//                        if (sourceProperty != null)
//                        {
//                            expandoDict.Add(property, sourceProperty.GetValue(item));
//                        }
//                    }

//                    this.Add(expando);
//                }
//            }



//        }

//        //        In this example, the ElasticCollection class inherits from List<ExpandoObject> and takes two parameters in its constructor:

//        //IEnumerable<T> source: The source collection that you want to make elastic.
//        //params string[] properties: The properties that you want to display in the elastic collection.
//        //The constructor uses reflection to get the properties of the source object, and if no properties are specified, it adds all the properties of the source object. Then it uses LINQ to select the specified properties from the source object and add them as dynamic properties to the ExpandoObject.Finally, it adds the ExpandoObject to the ElasticCollection.

//        //You can use the ElasticCollection class like this:







////        var products = new List<Product>
////{
////    new Product { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 1000 },
////    new Product { Id = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 200, Category = "Chairs", OrderCount = 4000 },
////    new Product { Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 }
////};

////        When properties are not specified, all properties of the products are listed
////       var elasticCollection = new ElasticCollection<Product>(products);

////         When the client specifies properties like Name, Quantity, OrderCount
////        var elasticCollection2 = new ElasticCollection<Product>(products, "Name", "Quantity", "OrderCount")
////            foreach (dynamic product in elasticCollection)
////        {
////            Console.WriteLine(product.Id + ", " + product.Name + ", " + product.Quantity + ", $" + product.Price + ", " + product.Category + ", " + product.OrderCount);
////            }

////         foreach (dynamic product in elasticCollection2)
////{
////    Console.WriteLine(product.Name + ", " + product.Quantity + ", " + product.OrderCount);
////}

////    }






//}
//}
