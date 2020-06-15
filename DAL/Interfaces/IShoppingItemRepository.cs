using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IShoppingItemRepository
    {
        ShoppingItem FindById(int id);
        void Save(ShoppingItem shoppingItem);
        ShoppingItem LastOrDefault();
        List<ShoppingItem> Get(int id);
        void Delete(int id);
        void UpdateShoppingItem(ShoppingItem shoppingItem);
        ShoppingItem FindShoppingItemByProductId(int id);

    }
}
