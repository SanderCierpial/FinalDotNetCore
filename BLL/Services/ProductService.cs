using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class ProductService : IProductService
    {
        IProductRepository repository;
        public ProductService(IProductRepository _repository)
        {
            repository = _repository;
        }

        public List<Product> GetAllProducts()
        {
            return repository.Get();
        }

        public void SaveProduct(Product product)
        {
            repository.Save(product);
        }

        public Product FindProductById(int id)
        {
            return repository.FindById(id);
        }
    }
}
