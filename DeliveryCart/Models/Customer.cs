using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Deliverycart.Models
{
    public class Customer : User
    {
        public int CustomerID {get;set;}     
        public string delivAdd {get;set;}= default!;
        //one to many
        public List<Order> Orders {get;set;}= default!;
        
        
    }
}