using ProductLibrary;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCollection
{
    class ElasticProductCollection
    {
        private List<Product> products;

        public ElasticProductCollection(List<Product> products)
        {
            this.products = products;
        }


        //ExpandoObject represents an object whose member can be added and removed at runtime
        public List<ExpandoObject> Get(params string[] properties)
        {
            var result = new List<ExpandoObject>();

            foreach (var product in products)
            {
                dynamic productExpando = new ExpandoObject();

                var productExpandoDict = productExpando as IDictionary<string, object>;

                if (properties.Length == 0)
                {
                    productExpandoDict["Id"] = product.Id;

                    productExpandoDict["Name"] = product.Name;

                    productExpandoDict["Quantity"] = product.Quantity;

                    productExpandoDict["Price"] = product.Price;

                    productExpandoDict["Category"] = product.Category;

                    productExpandoDict["OrderCount"] = product.OrderCount;
                }
                else
                {
                    foreach (var property in properties)
                    {
                        switch (property)
                        {
                            case "Id":

                                productExpandoDict["Id"] = product.Id;

                                break;

                            case "Name":

                                productExpandoDict["Name"] = product.Name;

                                break;

                            case "Quantity":

                                productExpandoDict["Quantity"] = product.Quantity;

                                break;

                            case "Price":

                                productExpandoDict["Price"] = product.Price;

                                break;

                            case "Category":

                                productExpandoDict["Category"] = product.Category;

                                break;

                            case "OrderCount":

                                productExpandoDict["OrderCount"] = product.OrderCount;

                                break;
                        }
                    }
                }
                result.Add(productExpando);
            }
            return result;
        }

        public void Print(List<ExpandoObject> expandoObjects, params string[] properties)
        {
            if (properties.Length == 0)
            {
                properties = new string[] { "Id", "Name", "Quantity", "Price", "Category", "OrderCount" };
            }
            var header = string.Join(", ", properties);

            Console.WriteLine(header);

            foreach (var expando in expandoObjects)
            {
                var dictionary = expando as IDictionary<string, object>;
                foreach (var item in dictionary)
                {
                    Console.Write(item.Key + ": " + item.Value + ", ");
                }
                Console.WriteLine();
            }

        }



    }


   
}
