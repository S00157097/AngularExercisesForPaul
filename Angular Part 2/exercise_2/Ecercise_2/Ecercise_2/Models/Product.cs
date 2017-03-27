using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ecercise_2.Models
{
    public class Product
    {
        public Product() { }
        public Product(string description, int recordLevel, int recordQuantity, decimal unitPrice, int stockOnHand)
        {
            this.Description = description;
            this.RecordLevel = recordLevel;
            this.RecordQuantity = recordQuantity;
            this.UnitPrice = unitPrice;
            this.StockOnHand = stockOnHand;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Description { get; set; }
        public int RecordLevel { get; set; }
        public int RecordQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockOnHand { get; set; }
    }
}