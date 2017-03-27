namespace Ecercise_2.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Ecercise_2.Models.OrderDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(OrderDbContext context)
        {
           /* context.Customers.AddOrUpdate(customer => customer.Id,
                new Customer("Danny Graham", "123 Belview Terrace", 2285),
                new Customer("Paul Bucannon", "23 The Lawns", 2675),
                new Customer("Mark Noble", "1 London Stadium", 3393),
                new Customer("PJ Harvey", "The Rocky Road", 3393)
                );

           context.Orders.AddOrUpdate(order => order.Id,
                new Order(new DateTime(2016, 1, 9), "Bill Bloggs", 5),
                new Order(new DateTime(2016, 1, 12), "Fred Couples", 5),
                new Order(new DateTime(2017, 1, 9), "Billy Fish", 6),
                new Order(new DateTime(2016, 1, 12), "Edwena Curry", 6),
                new Order(new DateTime(2016, 10, 7), "Billy Fish", 7),
                new Order(new DateTime(2017, 1, 25), "Marty Carty", 7),
                new Order(new DateTime(2015, 1, 9), "Carlos Santana", 8),
                new Order(new DateTime(2016, 11, 25), "Mary Carrty", 8)
                );*/

            context.Products.AddOrUpdate(product => product.Id,
                new Product("9 inch nails", 200, 1000, 0.25m, 320),
                new Product("6 inch nails", 100, 500, 0.12m, 32),
                new Product("Glass hammer", 20, 100, 50m, 32),
                new Product("Siege hammer", 20, 100, 42.5m, 32),
                new Product("Big nuts", 100, 350, 1m, 220),
                new Product("tool box", 10, 35, 100m, 22)
                );

            context.OrderLines.AddOrUpdate(orderLine => orderLine.Id,
                new OrderLine(25, 1, 6),
                new OrderLine(24, 3, 13),
                new OrderLine(24, 3, 6),
                new OrderLine(23, 3, 16),
                new OrderLine(23, 5, 8),
                new OrderLine(24, 5, 8),
                new OrderLine(25, 5, 8),
                new OrderLine(26, 5, 16),
                new OrderLine(27, 5, 8),
                new OrderLine(28, 5, 8),
                new OrderLine(29, 5, 8),
                new OrderLine(30, 5, 16)
                );

            context.SaveChanges();
        }
    }
}
