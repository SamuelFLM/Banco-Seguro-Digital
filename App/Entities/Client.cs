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
        public Client(int id, string name, string cpf)
        {
            Id = id;
            Name = name;
            CPF = cpf;
        }
        private int Id { get; set; }
        protected string Name { get; set; }
        protected string CPF { get; set; }

        public abstract void CloseAccount();

        public abstract void CreateAccount();

    }
}