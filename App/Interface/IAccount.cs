using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Interface
{
    public interface IAccount
    {
        public void Deposit(double balance);

        public void WithDraw(double balance);
        
    }
}