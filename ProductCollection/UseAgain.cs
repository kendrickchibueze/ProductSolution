//using System;
//using System.Collections.Generic;
//using System.Dynamic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProductCollection
//{
//    internal class UseAgain
//    {
       

//public class Product
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Quantity { get; set; }
//        public decimal Price { get; set; }
//        public string Category { get; set; }
//        public int OrderCount { get; set; }
//    }

//    public class ElasticCollection<T>
//    {
//        private List<T> _items;

//        public ElasticCollection(List<T> items)
//        {
//            _items = items;
//        }

//        public List<ExpandoObject> ToExpandoObjectList(string[] properties = null)
//        {
//            // Use reflection to get the properties of the object
//            PropertyInfo[] props = typeof(T).GetProperties();

//            // If properties were specified, only use those for the ExpandoObject
//            if (properties != null)
//            {
//                props = props.Where(x => properties.Contains(x.Name)).ToArray();
//            }

//            // Use LINQ to select the specified properties of each object and add them to a new ExpandoObject
//            var expandoList = _items.Select(item =>
//            {
//                IDictionary<string, object> expando = new ExpandoObject();
//                foreach (PropertyInfo prop in props)
//                {
//                    expando.Add(prop.Name, prop.GetValue(item));
//                }
//                return (ExpandoObject)expando;
//            }).ToList();

//            return expandoList;
//        }


//            public static void Run()
//            {
//                    List<Product> products = new List<Product> {
//                    new Product { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 1000 },
//                    new Product { Id = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 200, Category = "Chairs", OrderCount = 4000 },
//                    new Product { Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 }
//                };

//                ElasticCollection<Product> elasticCollection = new ElasticCollection<Product>(products);

//                List<ExpandoObject> expandoList = elasticCollection.ToExpandoObjectList(new string[] { "Name", "Quantity", "OrderCount" });

//                //List<ExpandoObject> expandoList = elasticCollection.ToExpandoObjectList(new string[] { "Name", "Quantity", "OrderCount" });

//                foreach (ExpandoObject item in expandoList)
//                {
//                    Console.WriteLine(item.ToString());
//                }

//            }


         

//                // Output:
//                // { Name = Dell Xps, Quantity = 30, OrderCount = 1000 }
//                // { Name = Ergonomic Chair, Quantity = 400, OrderCount = 4000 }
//                // { Name = Table, Quantity = 500, OrderCount = 3000 }

            
//        }

//}
//}
