using System;
using System.Linq;
using System.Collections.Generic;

namespace EssentialLesson17Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("BMW", "Sergey", 111222));
            customers.Add(new Customer("Volvo", "Igor", 945633));
            customers.Add(new Customer("BMW", "Alexey", 2356454));
            customers.Add(new Customer("Moskvich", "Sergey", 111222));
            customers.Add(new Customer("Lada", "Sanya", 784565));
            customers.Add(new Customer("BMW", "Igor", 998755));
            customers.Add(new Customer("Volvo", "Alexey", 757565));

            List<Car> cars = new List<Car>();
            cars.Add(new Car("BMW", "M5", 2016, "White"));
            cars.Add(new Car("Volvo", "XC40", 2014, "Red"));
            cars.Add(new Car("Moskvich", "MSK", 1990, "Blue"));
            cars.Add(new Car("Lada", "Priora", 2000, "Black"));


            var groupJoin = from iCar in cars
                            join iCustomer in customers on iCar.Brand equals iCustomer.Brand into gr
                            select new { Cars = iCar, Customer = gr, CustCount = gr.Count() };

            foreach (var item in groupJoin)
            {
                Console.WriteLine($"Brand: {item.Cars.Brand}, Count: {item.CustCount}");
                Console.WriteLine(new string('-', 20));
                
                foreach (var itemCust in item.Customer)
                {
                    Console.WriteLine($"Model: {item.Cars} => Client [Name:{itemCust.Name}, phone: {itemCust.PhoneNumber}]");
                }
                Console.WriteLine(new string('-', 20));
                Console.WriteLine();
            }

        }
    }
}
