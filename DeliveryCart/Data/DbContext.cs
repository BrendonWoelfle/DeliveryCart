#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Deliverycart.Models;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<Deliverycart.Models.Order> Order { get; set; }
        public DbSet<deliverycart.Models.Item> Item { get; set; }
        public DbSet<deliverycart.Models.Customer> Customer { get; set; }
        public DbSet<deliverycart.Models.Vendor> Vendor { get; set; }
        public DbSet<deliverycart.Models.Manager> Manager { get; set; }
        public DbSet<deliverycart.Models.Shopper> Shopper { get; set; }

        #region snippet2
        public async virtual Task AddOrderAsync (deliverycart.Models.Order order){
           await Order.AddAsync(order);
           await SaveChangesAsync();
        }
        #endregion
    }
