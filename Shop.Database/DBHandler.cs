using Shop.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Database
{
    public class DBHandler : DbContext
    {
        public DBHandler() :base("DBECom") {}

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }
    }
}
