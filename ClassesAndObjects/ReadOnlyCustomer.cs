using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
    //working with Fields
    public class ReadOnlyCustomer
    {
        //fields
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        //constructors
        public ReadOnlyCustomer(int id)
        {
            this.Id = id;
        }
        public ReadOnlyCustomer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
        //using ReadOnly Modifier
        public void Promote()
        {
        }
    }
}
