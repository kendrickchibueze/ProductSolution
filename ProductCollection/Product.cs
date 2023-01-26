using ProductLibrary;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductCollection
{
    class ElasticProductCollection
    {
        private List<Product> products;


        // constructor that initializes the products list
        public ElasticProductCollection(List<Product> products)
        {
            this.products = products;
        }


        //        This code defines a public method in C# called "Get" that takes in a variable 
        //         number of string arguments and returns a List of ExpandoObjects.

        //        The List<ExpandoObject> return type means that the method will return a list of objects of type ExpandoObject.

        //         The params keyword before the string[] properties parameter indicates that the method can take in a 
        //         variable number of string arguments.This allows the caller of the method to pass in 
        //         any number of string arguments, which will be collected into a string array called "properties".

        //         This method might be used to retrieve a list of dynamic objects that have certain properties. 
        //         The properties parameter passed in is used to filter the objects returned by the method.








        // method that returns a list of ExpandoObjects, which are objects that can have properties added or removed at runtime
        public List<ExpandoObject> Get(params string[] properties)
        {
            var result = new List<ExpandoObject>();

            // loop through each product in the products list
            foreach (var product in products)
            {
                dynamic productExpando = new ExpandoObject();

                //create a  productExpandoDict  which is an instance of IDictionary.It is assigned the productExpando object cast as this interface type.
                //This allows the properties of the productExpando object to be accessed as key-value pairs

                var productExpandoDict = productExpando as IDictionary<string, object>;

                // if no properties are passed in as an argument, add all properties to the ExpandoObject

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
                    // loop through each property passed in as an argument and add it to the ExpandoObject
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


        // method that takes in a list of ExpandoObjects and an array of properties to print
        public void Print(List<ExpandoObject> expandoObjects, params string[] properties)
        {

            // if no properties are passed in as an argument, use all properties

            if (properties.Length == 0)
            {
                properties = new string[] { "Id", "Name", "Quantity", "Price", "Category", "OrderCount" };
            }

            // create a header string by joining the properties array
            var header = string.Join(", ", properties);

            Utility.PrintColorMessage(ConsoleColor.Yellow, header + "\n\n");

            // loop through each ExpandoObject in the expandoObjects list

            foreach (var expando in expandoObjects)
            {

                //create a dictionary which is an instance of IDictionary.It is assigned the expando object cast as this interface type.
                //This allows the properties of the expando object to be accessed as key-value pairs

                var dictionary = expando as IDictionary<string, object>;


                // loop through each property-value pair in the ExpandoObject and print it

                foreach (var item in dictionary)
                {
                    Utility.PrintColorMessage(ConsoleColor.Green, item.Key + ": " + item.Value + "," );
                }


                Console.WriteLine();
            }

        }



    }


   
}
