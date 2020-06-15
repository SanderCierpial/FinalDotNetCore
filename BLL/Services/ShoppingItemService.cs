using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class ShoppingItemService : IShoppingItemService
    {
        IShoppingItemRepository repository;
        public ShoppingItemService(IShoppingItemRepository _repository)
        {
            repository = _repository;
        }

        public ShoppingItem FindShoppingItemById(int id)
        {
            return repository.FindById(id);
        }

        public List<ShoppingItem> GetAllShoppingItemsByBagId(int id)
        {
            return repository.Get(id);
        }

        public ShoppingItem LastOrDefault()
        {
            return repository.LastOrDefault();
        }

        public void SaveShoppingItem(ShoppingItem shoppingItem)
        {
            repository.Save(shoppingItem);
        }

        public void DeleteShoppingItem(int id)
        {
            repository.Delete(id);
        }

        public void UpdateShoppingItem(ShoppingItem shoppingItem)
        {
            repository.UpdateShoppingItem(shoppingItem);
        }

        public ShoppingItem FindShoppingItemByProductId(int id)
        {
            return repository.FindShoppingItemByProductId(id);
        }

    }
}
