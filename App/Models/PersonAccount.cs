using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entities;

namespace App.Models
{
    public class PersonAccount : Account
    {
        public PersonAccount(){}
        public PersonAccount(int id, double balance, int number, int idClient) : base(id, balance, number, idClient)
        {
            Persons = new List<Person>();
        }
        public List<Person> Persons { get; private set; }
        public override void Deposit(double balance)
        {
            Balance += balance;
            Console.WriteLine("Deposit Congratulations!");
            Console.WriteLine($"Balance Actually: {Balance:C2}");
        }

        public override void WithDraw(double balance)
        {
            if (Balance > balance)
            {
                Balance -= balance;
                Console.WriteLine("WithDraw Congratulations!");
                Console.WriteLine($"Balance Actually: {Balance:C2}");
            }
            else
                throw new Exception("Message erro!");
        }
    }
}