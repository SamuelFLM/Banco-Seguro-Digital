using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Interface;

namespace App.Entities
{
    public class Account : IAccount
    {
        public int Id { get; private set; }
        public double Balance { get; private set; }
        public int Number { get; private set; }
        public int IdClient{ get; private set; }
        
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