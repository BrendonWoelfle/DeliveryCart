using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Deliverycart.Models
{
    public class User
    {
        public int UserID {get;set;}

        public string FirstName {get;set;}= default!;

        public string LastName {get;set;}    = default!;    
        public string Address {get;set;}= default!;
        public string City {get;set;}= default!;
        public string State {get;set;}= default!;
        public int zipCode {get;set;}
        public int bankRoutingNum {get;set;}
        public int bankAccountNum {get;set;}        

    }
}