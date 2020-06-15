using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IProductRepository
    {
        List<Product> Get();
        Product FindById(int id);
        void Save(Product product);
    }
}
