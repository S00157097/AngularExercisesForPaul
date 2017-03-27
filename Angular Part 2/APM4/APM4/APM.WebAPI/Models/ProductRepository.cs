using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Hosting;

namespace APM.WebAPI.Models
{
    /// <summary>
    /// Stores the data in a json file so that no database is required for this
    /// sample application
    /// </summary>
    public class ProductRepository
    {
        private ApplicationDbContext context;

        public ProductRepository()
        {

        }

        public ProductRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Creates a new product with default values
        /// </summary>
        /// <returns></returns>
        internal Product Create()
        {
            Product product = new Product
            {
                ReleaseDate = DateTime.Now
            };
            return product;
        }

        /// <summary>
        /// Retrieves the list of products.
        /// </summary>
        /// <returns></returns>
        internal List<Product> Retrieve()
        {
            return this.context.Products.ToList();
        }

        /// <summary>
        /// Saves a new product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        internal Product Save(Product product)
        {
            this.context.Products.Add(product);
            return product;
        }

        /// <summary>
        /// Updates an existing product
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        internal Product Save(int id, Product product)
        {
            var prod = this.context.Products.Find(id);
            prod = product;
            this.context.SaveChanges();

            return product;
        }
    }
}