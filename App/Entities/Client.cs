using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Interface;

namespace App.Entities
{
    public class Client : IClient
    {
        public Client(string name, string cpf)
        {
            Name = name;
            CPF = cpf;
            Accounts = new List<Account>();
        }
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string CPF { get; private set; }

        public List<Account> Accounts { get; private set; }

        public void Deposit(double balance)
        {
            throw new NotImplementedException();
        }

        public void WithDraw(double balance)
        {
            throw new NotImplementedException();
        }
    }
}