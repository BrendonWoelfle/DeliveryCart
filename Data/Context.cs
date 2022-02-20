using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Deliverycart.Models;

    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Deliverycart.Models.Item> Item { get; set; }
        public DbSet<Deliverycart.Models.Order> Order { get; set; }
        public DbSet<Deliverycart.Models.Customer> Customer { get; set; }
        public DbSet<Deliverycart.Models.Vendor> Vendor { get; set; }
        public DbSet<Deliverycart.Models.Manager> Manager { get; set; }
        public DbSet<Deliverycart.Models.Shopper> Shopper { get; set; }
    
        #region snippet2
        public async virtual Task AddOrderAsync (Deliverycart.Models.Order order){
           await Order.AddAsync(order);
           await SaveChangesAsync();
        }
        #endregion
    
    }