using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Interface
{
    public interface IAccount
    {
        void CreateAccount();
        void CloseAccount(int number);
    }
}