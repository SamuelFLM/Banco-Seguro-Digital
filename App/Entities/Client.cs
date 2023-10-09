using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Interface;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace App.Entities
{
    public abstract class Client : IClient
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

        public abstract void CloseAccount();

        public abstract void CreateAccount();
        
    }
}