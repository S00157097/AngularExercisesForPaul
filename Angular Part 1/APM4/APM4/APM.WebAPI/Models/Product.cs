using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APM.WebAPI.Models
{
    public class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductCode { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Product()
        {

        }

        public Product(string description, decimal price, string productCode, int productId, string productName, DateTime releaseDate)
        {
            this.Description = description;
            this.Price = price;
            this.ProductCode = productCode;
            this.ProductName = productName;
            this.ProductId = productId;
            this.ReleaseDate = releaseDate;
        }
    }
}