using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;
using System.Security.Claims;
using System.Xml.Linq;

namespace ProductCollection
{
    //internal class CheckMe
    //{
      

    //    public class Product
    //        {
    //            public int Id { get; set; }
    //            public string Name { get; set; }
    //            public int Quantity { get; set; }

    //            public decimal Price { get; set; }
    //            public string Category { get; set; }
    //            public int OrderCount { get; set; }
    //        }

    //class ElasticCollection
    //{
    //    public List<Product> Products { get; set; }

    //    public ElasticCollection(List<Product> products)
    //    {
    //        Products = products;
    //    }

    //    public List<ExpandoObject> List(List<string> properties = null)
    //    {
    //        if (properties == null)
    //        {
    //            properties = typeof(Product).GetProperties().Select(p => p.Name).ToList();
    //        }

    //        var expandoList = new List<ExpandoObject>();
    //        foreach (var product in Products)
    //        {
    //            dynamic expando = new ExpandoObject();
    //            var expandoDict = expando as IDictionary<string, object>;

    //            foreach (var property in properties)
    //            {
    //                var propertyValue = typeof(Product).GetProperty(property)?.GetValue(product);
    //                expandoDict[property] = propertyValue;
    //            }

    //            expandoList.Add(expando);
    //        }

    //        return expandoList;
    //    }




    

            //public static void Run()
            //{
             
            //    var products = new List<Product>
            //    {
            //        new Product { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 1000 },
            //        new Product { Id = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 200, Category = "Chairs", OrderCount = 4000 },
            //        new Product { Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 }
            //    };

            //    var elasticCollection = new ElasticCollection(products);

            //    var expandoList = elasticCollection.List();

            //    foreach (var expando in expandoList)
            //    {
            //        Console.WriteLine(expando);
            //    }
            //    Console.WriteLine("------------------------------");

            //    var properties = new List<string> { "Name", "Quantity", "OrderCount" };
            //    var expandoList_1 = elasticCollection.List(properties);

            //    foreach (var expando in expandoList_1)
            //    {
            //        Console.WriteLine(expando);
            //    }
            //}
        
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var products = new List<Product>
    //    {
    //        new Product { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 1000 },
    //        new Product { Id = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 200, Category = "Chairs", OrderCount = 4000 },
    //        new Product { Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 }
    //    };

    //        var elasticCollection = new ElasticCollection(products);

    //        var expandoList = elasticCollection.List();

    //        foreach (var expando in expandoList)
    //        {
    //            Console.WriteLine(expando);
    //        }
    //        Console.WriteLine("------------------------------");

    //        var properties = new List<string> { "Name", "Quantity", "OrderCount" };
    //        var expandoList_1 = elasticCollection.List(properties);

    //        foreach (var expando in expandoList_1)
    //        {
    //            Console.WriteLine(expando);
    //            }
    //        }
    //    }


//}



//sample output
//{ Id = 1, Name = Dell Xps, Quantity = 30, Price = 1500, Category = PCs, OrderCount = 1000 }
//{ Id = 2, Name = Ergonomic Chair, Quantity = 400, Price = 200, Category = Chairs, OrderCount = 4000 }
//{ Id = 3, Name = Table, Quantity = 500, Price = 250, Category = Tables, OrderCount = 3000 }
//------------------------------
//{ Name = Dell Xps, Quantity = 30, OrderCount = 1000 }
//{ Name = Ergonomic Chair, Quantity = 400, OrderCount = 4000 }
//{ Name = Table, Quantity = 500, OrderCount = 3000 }
