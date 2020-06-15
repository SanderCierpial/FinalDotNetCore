using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IShoppingItemService
    {
        ShoppingItem FindShoppingItemById(int id);

        void SaveShoppingItem(ShoppingItem shoppingItem);

        ShoppingItem LastOrDefault();

        List<ShoppingItem> GetAllShoppingItemsByBagId(int id);

        void DeleteShoppingItem(int id);

        void UpdateShoppingItem(ShoppingItem shoppingItem);

        ShoppingItem FindShoppingItemByProductId(int id);


    }

}
