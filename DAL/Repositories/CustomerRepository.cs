using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        DataContext context;
        public CustomerRepository(DataContext _context)
        {
            context = _context;
        }

        public List<Customer> Get()
        {
            return context.Customers.ToList();
        }

        public Customer FindById(int id)
        {
            return context.Customers.Where(u => u.Id == id).Single();
        }

        public void Save(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}
