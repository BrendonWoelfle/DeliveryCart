#nullable disable
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;



namespace Deliverycart.Models
{
    public class Order
    {   
        public int OrderID {get;set;}
        public int CustomerID {get;set;}
        public int ItemID {get;set;}    
        public int Qty {get;set;}
        public Customer Customer {get;set;}= default!;
        public Item Item {get;set;}= default!;


    }
}