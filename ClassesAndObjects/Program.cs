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
            //classes an objects from above
            Person person = Person.Parse("Alex");
            person.Introduce("Bill");
            
            //constructors on Customer.cs and Order.cs
            Customer customer = new Customer(1, "Shawn");
            
            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);   
         }

        //methods on Point.cs
        //overloading
        static void UsePoints()
        {
                try
                {
                    var point = new Point(10, 20);
                    point.Move(null);
                    Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

                    point.Move(100, 200);
                    Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);

                }
                catch (Exception)
                {
                    Console.WriteLine("An unexpected error occured");
                }

        }
    }
}
