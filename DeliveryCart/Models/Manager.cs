using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Deliverycart.Models
{
    public class Manager : Shopper
    {
        public int ManagerID {get;set;}  = default!;
        public string name {get;set;} = default!;
        public string pwd {get;set;} = default!;
        public List<Shopper> Shopper{get;set;}= default!;
    }

}