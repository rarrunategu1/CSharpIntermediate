using System;

namespace ClassesAndObjects
{
    public class Person
    {
        public string Name;
        
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        public static Person Parse(string str)
        {
            Person person = new Person();
            person.Name = str;

            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = Person.Parse("Alex");
            person.Introduce("Bill");

            Customer customer = new Customer(1, "Shawn");
            
            var order = new Order();
            customer.Orders.Add(order);
            
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
