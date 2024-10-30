using System;
using System.Collections.Generic;
using WebApplication9.Models;

namespace WebApplication9.Services
{
    public class ProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { ID = 1, Name = "Phone Samsung Galaxy A31", Price = 599.99M, CreatedDate = DateTime.Now },
                new Product { ID = 2, Name = "Headphines JBL710", Price = 199.99M, CreatedDate = DateTime.Now },
                new Product { ID = 3, Name = "Case for Samsung Galaxy A31", Price = 29.99M, CreatedDate = DateTime.Now }
            };
        }
    }
}
