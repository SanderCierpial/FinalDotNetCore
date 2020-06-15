using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class ShoppingItemRepository : IShoppingItemRepository
    {
        DataContext context;
        public ShoppingItemRepository(DataContext _context)
        {
            context = _context;
        }

        public ShoppingItem FindById(int id)
        {
            return context.ShoppingItems.Where(u => u.Id == id).Single();
        }

        public void Save(ShoppingItem shoppingItem)
        {
            context.ShoppingItems.Add(shoppingItem);
            context.SaveChanges();
        }

        public ShoppingItem LastOrDefault()
        {
            return context.ShoppingItems.LastOrDefault();
        }

        public List<ShoppingItem> Get(int id)
        {
            //List<ShoppingItem> items = context.ShoppingItems.Where(r => r.ShoppingBag.Id == id).ToList();
            return context.ShoppingItems.Where(r => r.ShoppingBag.Id == id).ToList();
        }

        public void Delete(int id)
        {
            var item = context.ShoppingItems.SingleOrDefault(r => r.Id == id);
            context.ShoppingItems.Remove(item);
            context.SaveChanges();
        }

        public void UpdateShoppingItem(ShoppingItem shoppingItem)
        {
            context.ShoppingItems.Update(shoppingItem);
            context.SaveChanges();
        }

        public ShoppingItem FindShoppingItemByProductId(int id)
        {
            try
            {
                if (context.ShoppingItems.Where(u => u.ProductId == id).Single() == null)
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            ShoppingItem item = context.ShoppingItems.SingleOrDefault(r => r.ProductId == id);
            return item;
        }

    }
}
