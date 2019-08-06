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
            
            //var order = new Order();
            //customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            //using Out Modifier
            //var number = int.Parse("abc");
            //returns exception - input string is not in correct format
            //can be fixed with try catch block or the following:
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }

            //readonly modifier example
            var readonlycustomer = new ReadOnlyCustomer(1);
            readonlycustomer.Orders.Add(new Order());
            readonlycustomer.Orders.Add(new Order());

            //because we initialize the list here again we lose all of the data and it becomes zero
            readonlycustomer.Promote();

            Console.WriteLine(readonlycustomer.Orders.Count);

            //PersonAccessModifier Practice
            PersonAccessModifier personEx = new PersonAccessModifier();
            personEx.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(personEx.GetBirthdate());

         }

         static void UseParams()
         {
            //method overloading in Calculator.cs
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(new int[]{1, 2, 3, 4}));
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
