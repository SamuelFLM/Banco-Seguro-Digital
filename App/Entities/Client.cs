using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Interface;

namespace App.Entities
{
    public class Client : IClient
    {
        public Client(string? name, string? cpf)
        {
            Name = name;
            CPF = cpf;
        }

        private string? Name { get; set; }
        private string? CPF { get; set; }

        public void Depositar()
        {
            throw new NotImplementedException();
        }

        public void Sacar()
        {
            throw new NotImplementedException();
        }
    }
}