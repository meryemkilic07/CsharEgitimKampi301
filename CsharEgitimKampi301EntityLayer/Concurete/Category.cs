using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace CsharEgitimKampi301EntityLayer.Concurete
{
    public class Category
    {
        public int CategoryId{ get; set; }
        public string CategoryName { get; set; }//get set blokları arasında tanımlann deger. get aalmak set kural koymak
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }




    }
}
