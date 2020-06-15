using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class ShoppingBagRepository : IShoppingBagRepository
    {
        DataContext context;
        public ShoppingBagRepository(DataContext _context)
        {
            context = _context;
        }

        public ShoppingBag FindById(int id)
        {
            return context.ShoppingBags.Where(u => u.Id == id).Single();
        }

        public void Save(ShoppingBag shoppingBag)
        {
            context.ShoppingBags.Add(shoppingBag);
            context.SaveChanges();
        }

        public void Update(ShoppingBag shoppingBag)
        {
            context.ShoppingBags.Update(shoppingBag);
            context.SaveChanges();
        }

        public ShoppingBag LastOrDefault()
        {
            return context.ShoppingBags.LastOrDefault();
        }

        public double CalculateShoppingBag(ShoppingBag shoppingBag)
        {

            double sum = 0;
            foreach (var item in shoppingBag.ShoppingItems)
            {
                int id = item.ProductId;
                Product product = context.Products.Where(u => u.Id == id).Single();
                sum += item.Quantity * product.Price;
            }
            if (shoppingBag.ShoppingItems.Count>=3)
            {
                sum *=0.95;
            }
            if (shoppingBag.ShoppingItems.Count>=6)
            {
                sum *= 0.90;
            }
            sum = Math.Round(sum, 2);
            shoppingBag.Total = sum;
            return sum;
        }

    }
}
