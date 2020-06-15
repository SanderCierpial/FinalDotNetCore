﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAllProducts();

        void SaveProduct(Product product);

        Product FindProductById(int id);
    }
}
