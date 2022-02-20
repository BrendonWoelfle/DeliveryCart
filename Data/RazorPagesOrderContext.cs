#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Deliverycart.Models;

    public class RazorPagesOrderContext : DbContext
    {
        public RazorPagesOrderContext (DbContextOptions<RazorPagesOrderContext> options)
            : base(options)
        {
        }

        public DbSet<Deliverycart.Models.Order> Order { get; set; }
    }
