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
        private int Id { get;  set; }
        protected double Balance { get;  set; }
        private int Number { get;  set; }
        private int IdClient { get;  set; }

        public abstract void Deposit(double balance);
        public abstract void WithDraw(double balance);

    }
}