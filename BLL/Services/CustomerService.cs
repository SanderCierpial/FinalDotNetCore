using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository repository;
        public CustomerService(ICustomerRepository _repository)
        {
            repository = _repository;
        }

        public Customer FindCustomerById(int id)
        {
            return repository.FindById(id);
        }

        public List<Customer> GetAllCustomers()
        {
            return repository.Get();
        }

        public void SaveCustomer(Customer customer)
        {
            repository.Save(customer);
        }
    }
}
