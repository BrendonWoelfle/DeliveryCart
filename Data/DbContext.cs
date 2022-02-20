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
        public DbSet<Deliverycart.Models.Item> Item {get; set;}
        public DbSet<Deliverycart.Models.Order> Order { get; set; }
        public DbSet<Deliverycart.Models.Customer> Customer { get; set; }
        public DbSet<Deliverycart.Models.Vendor> Vendor { get; set; }
        public DbSet<Deliverycart.Models.Manager> Manager { get; set; }
        public DbSet<Deliverycart.Models.Shopper> Shopper { get; set; }
    }
