using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopBridge.Models
{
    public class Inventory
    {
        
        public int id { get; set; }
        [Required]
        [Display(Name ="Product")]
        public string name { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        [Display(Name = "Price")]
        public decimal price { get; set; }
        [Required]
        [Display(Name = "Stock")]
        public int noOfAvailibity { get; set; }
        [Display(Name = "Available")]
        public bool availbility { get; set; }
    }
}