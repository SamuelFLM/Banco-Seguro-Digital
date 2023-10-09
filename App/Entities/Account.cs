using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Interface;

namespace App.Entities
{
    public abstract class Account : IAccount
    {
        public Account(int id, double balance, int number, int idClient)
        {
            Id = id;
            Balance = balance;
            Number = number;
            IdClient = idClient;
        }
        public int Id { get;  private set; }
        public double Balance { get;  set; }
        public int Number { get;  private set; }
        public int IdClient { get;  private set; }

        public abstract void Deposit(double balance);
        public abstract void WithDraw(double balance);

    }
}