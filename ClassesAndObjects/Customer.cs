using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    //using a constructor
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
        //calling constructor without parameters for instantiation
            : this()
        {
            this.Id = id;
        }
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
