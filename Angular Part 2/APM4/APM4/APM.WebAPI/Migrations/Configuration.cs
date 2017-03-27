namespace APM.WebAPI.Migrations
{
    using Models;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Hosting;

    internal sealed class Configuration : DbMigrationsConfiguration<APM.WebAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(APM.WebAPI.Models.ApplicationDbContext context)
        {
            /*var filePath = HostingEnvironment.MapPath(@"~/App_Data/product.json");

            var json = System.IO.File.ReadAllText(filePath);

            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);

            products.ForEach(p => context.Products.AddOrUpdate(prod => prod.ProductId, p));
            "Description": "Leaf rake with 48-inch wooden handle.",
    "Price": 19.95,
    "ProductCode": "GDN-0011",
    "ProductId": 1,
    "ProductName": "Leaf Rake",
    "ReleaseDate": "2009-03-19T00:00:00-07:00"
            */

            context.Products.AddOrUpdate(p => p.ProductId,
                new Product
                {
                    Description = "Some description about this product",
                    Price = 19.95m,
                    ProductCode = "GDN-0011",
                    ProductId = 1,
                    ProductName = "Leaf Rake",
                    ReleaseDate = DateTime.Now
                }
                );

            context.SaveChanges();
        }
    }
}
