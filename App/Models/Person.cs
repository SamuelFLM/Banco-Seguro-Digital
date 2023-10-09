using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entities;

namespace App.Models
{
    public class Person : Client
    {
        public Person(int id, string name, string cpf) : base(id, name, cpf)
        {
            Accounts = new List<PersonAccount>();
        }
        public List<PersonAccount> Accounts { get; private set; }
        public override void CloseAccount()
        {
            throw new NotImplementedException();
        }

        public override void CreateAccount()
        {
            throw new NotImplementedException();
        }
    }
}