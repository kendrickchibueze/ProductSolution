//using System;
//using System.Collections.Generic;
//using System.Dynamic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Dynamic;
//using System.Collections.Generic;

//namespace ProductCollection
//{
//    internal class AgainProduct
//    {

  

//  class Product
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Quantity { get; set; }
//        public decimal Price { get; set; }
//        public string Category { get; set; }
//        public int OrderCount { get; set; }
//    }

//    class ElasticProductCollection
//    {
//        private List<Product> products;

//        public ElasticProductCollection(List<Product> products)
//        {
//            this.products = products;
//        }

//        public List<ExpandoObject> Get(params string[] properties)
//        {
//            var result = new List<ExpandoObject>();
//            foreach (var product in products)
//            {
//                dynamic productExpando = new ExpandoObject();
//                var productExpandoDict = productExpando as IDictionary<string, object>;
//                if (properties.Length == 0)
//                {
//                    productExpandoDict["Id"] = product.Id;
//                    productExpandoDict["Name"] = product.Name;
//                    productExpandoDict["Quantity"] = product.Quantity;
//                    productExpandoDict["Price"] = product.Price;
//                    productExpandoDict["Category"] = product.Category;
//                    productExpandoDict["OrderCount"] = product.OrderCount;
//                }
//                else
//                {
//                    foreach (var property in properties)
//                    {
//                        switch (property)
//                        {
//                            case "Id":
//                                productExpandoDict["Id"] = product.Id;
//                                break;
//                            case "Name":
//                                productExpandoDict["Name"] = product.Name;
//                                break;
//                            case "Quantity":
//                                productExpandoDict["Quantity"] = product.Quantity;
//                                break;
//                            case "Price":
//                                productExpandoDict["Price"] = product.Price;
//                                break;
//                            case "Category":
//                                productExpandoDict["Category"] = product.Category;
//                                break;
//                            case "OrderCount":
//                                productExpandoDict["OrderCount"] = product.OrderCount;
//                                break;
//                        }
//                    }
//                }
//                result.Add(productExpando);
//            }
//            return result;
//        }
//    }


//}
//}
