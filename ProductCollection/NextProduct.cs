using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCollection
{
    //internal class NextProduct
    //{



    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int OrderCount { get; set; }
    }

    class ElasticCollection
    {



        List<Product> products;
    

        public ElasticCollection(List<Product> products)
        {
            this.products = products;
        }

        public IEnumerable<ExpandoObject> Get(IEnumerable<string> properties = null)
        {
            if (properties == null)
            {
                properties = typeof(Product).GetProperties().Select(p => p.Name);
            }

            return products.Select(p => ToExpando(p, properties));
        }

        private ExpandoObject ToExpando(Product product, IEnumerable<string> properties)
        {
            var expando = new ExpandoObject();
            var dictionary = (IDictionary<string, object>)expando;

            foreach (var property in properties)
            {
                var propertyInfo = product.GetType().GetProperty(property);
                if (propertyInfo != null)
                {
                    var value = propertyInfo.GetValue(product);
                    dictionary.Add(property, value);
                }
            }

            return expando;
        }
    }

    class Programmer
    {
        public static void Run()
        {
            var products = new List<Product>
        {
            new Product { Id = 1, Name = "Dell Xps", Quantity = 30, Price = 1500, Category = "PCs", OrderCount = 1000 },
            new Product { Id = 2, Name = "Ergonomic Chair", Quantity = 400, Price = 200, Category = "Chairs", OrderCount = 4000 },
            new Product { Id = 3, Name = "Table", Quantity = 500, Price = 250, Category = "Tables", OrderCount = 3000 }
        };

            var elasticCollection = new ElasticCollection(products);

            var allProperties = elasticCollection.Get();
            Console.WriteLine("All Properties:");
            foreach (var item in allProperties)
            {
                Console.WriteLine(item);
            }

            var specificProperties = elasticCollection.Get(new[] { "Name", "Quantity", "OrderCount" });
            Console.WriteLine("Specific Properties:");
            foreach (var item in specificProperties)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }

}
//}
