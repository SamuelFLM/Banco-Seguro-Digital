using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class SerializeObj
    {
        public SerializeObj()
        {
            Accounts = new List<PersonAccount>();
        }
        public List<PersonAccount> Accounts { get; set; }
    }
}