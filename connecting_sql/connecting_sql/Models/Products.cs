using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace connecting_sql.Models
{
    public class Products
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}