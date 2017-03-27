using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ecercise_2.Models
{
    public class Customer
    {
        public Customer() { }
        public Customer(string name, string address, int rating)
        {
            this.Name = name;
            this.Address = address;
            this.CreditRating = rating;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CreditRating { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}