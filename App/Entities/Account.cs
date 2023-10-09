using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Interface;

namespace App.Entities
{
    public abstract class Account : IAccount
    {
        public Account(double balance, int number, int idCliente)
        {
            Balance = balance;
            Number = number;
            IdClient = idCliente;
        }
        public int Id { get; private set; }
        public double Balance { get; private set; }
        public int Number { get; private set; }
        public int IdClient { get; private set; }

        public void CloseAccount()
        {
        }

        public void CreateAccount()
        {
        }
    }
}