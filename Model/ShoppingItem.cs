using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ShoppingItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public ShoppingBag ShoppingBag { get; set; }
    }
}
