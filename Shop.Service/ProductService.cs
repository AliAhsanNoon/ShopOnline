using Shop.Database;
using Shop.Entites;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Service
{
    public class ProductService
    {
        DBHandler context = new DBHandler();

        public List<Product> GetProducts() { return context.Products.ToList(); }

        public void SaveProducts( Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public Product Edit(int ID) { return context.Products.ToList().SingleOrDefault(x => x.ID == ID); }

        public void Update(Product product)
        {
            context.Entry(product).State = EntityState.Modified;
            context.SaveChanges();
        }

    }
}
