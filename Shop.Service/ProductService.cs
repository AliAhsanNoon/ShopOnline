﻿using Shop.Database;
using Shop.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public class ProductService
    {
        DBHandler context = new DBHandler();

        public List<Product> GetProducts() { return context.Products.ToList(); }



    }
}
