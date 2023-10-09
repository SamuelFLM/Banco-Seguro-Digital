using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Interface;

namespace App.Entities
{
    public class Account : IAccount
    {
        public double Balance { get; set; }
        public int Number { get; set; }

        public void CreateAccount()
        {
            throw new NotImplementedException();
        }

        public void CloseAccount(int number)
        {
            throw new NotImplementedException();
        }
    }
}