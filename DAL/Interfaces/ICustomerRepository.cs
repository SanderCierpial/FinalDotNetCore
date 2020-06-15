using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> Get();
        Customer FindById(int id);
        void Save(Customer customer);
    }
}
