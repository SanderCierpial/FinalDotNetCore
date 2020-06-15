using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IShoppingBagRepository
    {
        ShoppingBag FindById(int id);
        void Save(ShoppingBag shoppingBag);
        void Update(ShoppingBag shoppingBag);

        ShoppingBag LastOrDefault();

        double CalculateShoppingBag(ShoppingBag shoppingBag);

    }
}
