using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entities;

namespace App.Models
{
    public class Person : Client
    {
        public Person()
        {

        }
        public Person(int id, string name, string cpf) : base(id, name, cpf)
        {
        }

        public override string CloseAccount()
        {
            return "Account close sucess!";
        }

        public override string CreateAccount()
        {
            return "Account created sucess!";
        }
    }
}