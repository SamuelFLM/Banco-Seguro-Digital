using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models;
using Xunit;

namespace Tests
{
    public class PersonAccountTests
    {
        private PersonAccount _account;

        public PersonAccountTests()
        {
            _account = new PersonAccount();
        }

        [Fact]
        public void DepositSucess()
        {
            _account.Balance = 50.00;

            _account.Deposit(50);

            Assert.Equal(100.00, _account.Balance);
        }

        [Fact]
        public void DepositFail()
        {
            _account.Balance = 50.00;

            _account.Deposit(50);

            Assert.False(120.00 == _account.Balance);
        }

        [Fact]
        public void WithDrawSucess()
        {
            _account.Balance = 10;

            _account.WithDraw(5);

            Assert.Equal(5.00, _account.Balance);
        }

        [Fact]
        public void WithDrawFail()
        {
            _account.Balance = 20;
            Assert.Throws<Exception>(() => _account.WithDraw(20));
        }
    }
}