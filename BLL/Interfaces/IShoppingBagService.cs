using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IShoppingBagService
    {
        ShoppingBag FindShoppingBagById(int id);

        void SaveShoppingBag(ShoppingBag shoppingBag);
        ShoppingBag LastOrDefault();
        void UpdateShoppingBag(ShoppingBag shoppingBag);
        double CalculateShoppingBag(ShoppingBag shoppingBag);

    }
}
