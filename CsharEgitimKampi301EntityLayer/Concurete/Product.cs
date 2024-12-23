using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace CsharEgitimKampi301EntityLayer.Concurete
{
   public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int  ProductStok { get; set; }
        public decimal  ProductPrice { get; set; }
        public string  ProductDecription{ get; set; }
        public int   CategoryId{ get; set; }
        public virtual Category Category{ get; set; }
        public List<Order> Orders{ get; set; }



    }
}
