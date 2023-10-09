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
        public Client() { }
        public Client(int id, string name, string cpf)
        {
            Id = id;
            Name = name;
            CPF = cpf;
        }
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string CPF { get; private set; }

        public abstract string CloseAccount();

        public abstract string CreateAccount();

    }
}