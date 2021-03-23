using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Batuhan", LastName = "Güner", City = "İstanbul" };
            Customer customer3 = new Customer();
            customer3.Id = 3;
            //customer1 ve customer3 kullanımı aynıdır, customer2 kullanımı bunlardan farklıdır. customer1 de new Customer() { } bu şekilde de yazılabilir.

            Customer customer2 = new Customer(2, "Nurbanu", "Sülün", "Kocaeli");


        }
    }

    class Customer
    {
        //default constructor
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
