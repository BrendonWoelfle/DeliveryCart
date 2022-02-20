using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Deliverycart.Models
{
    public class Item
    {
        public int ItemID {get;set;} 
        public int OrderID {get;set;}           
        public int itemQty {get;set;}
        public string itemName {get;set;}= default!;
        public List<Order> Order {get;set;}= default!;
        
    }
}