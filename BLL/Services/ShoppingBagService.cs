using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class ShoppingBagService : IShoppingBagService
    {
        IShoppingBagRepository repository;
        public ShoppingBagService(IShoppingBagRepository _repository)
        {
            repository = _repository;
        }

        public ShoppingBag FindShoppingBagById(int id)
        {

            return repository.FindById(id);
        }

        public ShoppingBag LastOrDefault()
        {
            return repository.LastOrDefault();
        }

        public void UpdateShoppingBag(ShoppingBag shoppingBag)
        {
            repository.Update(shoppingBag);
        }

        public void SaveShoppingBag(ShoppingBag shoppingBag)
        {
            repository.Save(shoppingBag);
        }

        public double CalculateShoppingBag(ShoppingBag shoppingBag)
        {
            return repository.CalculateShoppingBag(shoppingBag);
        }

    }
}
