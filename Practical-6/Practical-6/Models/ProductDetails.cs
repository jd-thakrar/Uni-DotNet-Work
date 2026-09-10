using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical_6.Models
{
    public class ProductDetails
    {
        public int id {  get; set; }
        public string imageUrl { get; set; }

        public string name { get; set; }

        public string category { get; set; }

        public string description { get; set; }

        public int price { get; set; }
    }
}