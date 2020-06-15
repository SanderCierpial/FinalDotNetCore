using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();

        void SaveCustomer(Customer customer);

        Customer FindCustomerById(int id);
    }
}
