using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace CsharEgitimKampi301EntityLayer.Concurete
{
    public class Customer
    {
        public int CustomerId { get; set; }//Id kısmı tablodaki ile aynı olmalı çünkü codefirst yaklaşımı bunu gerektirr.
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; }
        public bool CustomerStatus { get; set; }

    }
}
