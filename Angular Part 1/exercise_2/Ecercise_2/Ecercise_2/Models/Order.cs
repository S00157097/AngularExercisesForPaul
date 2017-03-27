using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ecercise_2.Models
{
    public class Order
    {
        public Order() { }
        public Order(DateTime orderDate, string enteredBy, int customer)
        {
            this.OrderDate = orderDate;
            this.EnteredBy = enteredBy;
            this.CustomerId = customer;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string EnteredBy { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}