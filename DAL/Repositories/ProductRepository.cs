using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        DataContext context;
        public ProductRepository(DataContext _context)
        {
            context = _context;
        }

        public List<Product> Get()
        {
            return context.Products.ToList();
        }

        public Product FindById(int id)
        {
            return context.Products.Where(u => u.Id == id).Single();
        }

        public void Save(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}
