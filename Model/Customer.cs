using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public List<ShoppingBag> ShoppingBags { get; set; }

    }
}
