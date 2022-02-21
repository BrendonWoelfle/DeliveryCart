#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Deliverycart.Models;

namespace DeliveryCart.Pages_Orders
{
    public class IndexModel : PageModel
    {
        private readonly DbContext _context;

        public IndexModel(DbContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order
                .Include(o => o.Customer)
                .Include(o => o.Item).ToListAsync();
        }
    }
}
