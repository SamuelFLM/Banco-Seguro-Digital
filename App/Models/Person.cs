using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entities;

namespace App.Models
{
    public class Person : Client
    {
        public Person(string name, string cpf) : base(name, cpf)
        { 

        }
        
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