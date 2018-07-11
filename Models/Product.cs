using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace itsAPI.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }

    }
}