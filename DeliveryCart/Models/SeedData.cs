using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace Deliverycart.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            // using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            // {
                // if (context.Addresses.Any())
                // {
                //     return;
                // }
         
                List<Customer> customer = new List<Customer> {
                    new Customer {FirstName="Laurie", LastName="Cornfoot", Address = "6114 Leopard Rd", City="Ropesville", State="Tx",zipCode=79358},
                    new Customer {FirstName="Conni", LastName="Spriggen",Address = "6116 Leopard Rd",City="Ropesville", State="Tx",zipCode=79358},
                    new Customer {FirstName="Darsey", LastName="Pervoe", Address = "3575 Mallard Rd",City="Ropesville", State="Tx",zipCode=79358},
                    new Customer {FirstName="Ninetta", LastName="Seccombe",Address = "6112 Leopard Rd",City="Ropesville", State="Tx",zipCode=79358},
                    new Customer {FirstName="Sibilla", LastName="Louisot", Address = "6116 Leopard Rd",City="Ropesville",State="Tx",zipCode=79358},
                    new Customer {FirstName="Harli", LastName="Jencken", Address = "5223 109th St",City="Lubbock", State="Tx",zipCode=79423},
                    new Customer {FirstName="Lisa", LastName="Dorrian", Address = "5123 109th St",City="Lubbock", State="Tx",zipCode=79423},

                };
            //     context.AddRange(customer);
            //     context.SaveChanges();
            // }
        }
    }
}