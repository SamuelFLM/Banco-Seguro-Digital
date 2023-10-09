using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entities;

namespace App.Interface
{
    public interface IClient
    {
        string CreateAccount();
        string CloseAccount();
    }
}