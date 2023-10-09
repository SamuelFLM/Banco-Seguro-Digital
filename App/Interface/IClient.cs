using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Interface
{
    public interface IClient
    {
        void WithDraw(double balance);
        void Deposit(double balance);
    }
}