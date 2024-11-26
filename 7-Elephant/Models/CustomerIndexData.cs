using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _7_Elephant.Models
{
    public class CustomerIndexData
    {
        public IEnumerable<Customers> Customers { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Phone> Phones { get; set; }


    }
}