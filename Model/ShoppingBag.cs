using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ShoppingBag
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public List<ShoppingItem> ShoppingItems { get; set; }
        public double Total { get; set; }
    }
}
