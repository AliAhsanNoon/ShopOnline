using Shop.Database;
using Shop.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
