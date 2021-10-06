using System;
using System.Collections.Generic;
using System.Text;
using CustomerApp.Data.Repository;
using CustomerApp.Data.Model;

namespace CustomerApp.ConsoleApp
{
    class ManageCust
    {
        IRepository<Cust> custRepository;
        public ManageCust()
        {
            custRepository = new CustRepository();
        }

        void AddCustomer()
        {
            Cust d = new Cust();
            Console.Write("Enter First Name = ");
            d.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name = ");
            d.LastName = Console.ReadLine();
            Console.Write("Enter Mobile Phone # = ");
            d.Mobile = Console.ReadLine();
            Console.Write("Enter ERmailId = ");
            d.EmailId = Console.ReadLine();
            Console.Write("Enter City = ");
            d.City = Console.ReadLine();
            Console.Write("Enter State = ");
            d.State = Console.ReadLine();

            if (custRepository.Insert(d) > 0)
                Console.WriteLine("Customer Added successfully");
            else
                Console.WriteLine("Some error has occured");
        }
        public void Run()
        {
            AddCustomer();
        }
    }
}
