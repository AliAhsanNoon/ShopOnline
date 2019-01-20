using Shop.Database;
using Shop.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public class CategoryService
    {
        DBHandler context = new DBHandler();

        public List<Category> GetCategories() { return context.Categories.ToList(); }

        // Save Record into Categories
        public void SaveCategory(Category category)
        {
            using (context)
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public Category GetCategory(int ID)
        {
            return context.Categories.ToList().SingleOrDefault(x => x.ID == ID);
        }

        public void UpdateCategory(Category category)
        {
            using (context)
            {
                context.Entry(category).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
