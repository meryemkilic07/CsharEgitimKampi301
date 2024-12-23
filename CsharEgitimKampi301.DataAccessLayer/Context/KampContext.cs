using CsharEgitimKampi301EntityLayer.Concurete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace CsharEgitimKampi301.DataAccessLayer.Context
{
    public class KampContext:DbContext
    {//veri tabanına yansıcak bütün sınıflar burda yer alır
    public DbSet<Category> Categories { get; set; }//Category:c# da tarafında kulanılacka sınıf,Categories:sql yansıcak tablo isimleri belirtir.

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins{ get; set; }



    }
}
