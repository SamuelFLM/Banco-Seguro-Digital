using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models;
using Xunit;

namespace Tests
{
    public class PersonTests
    {
        private Person _person;

        public PersonTests()
        {
            _person = new Person();
        }

        [Fact]
        public void ShouldReturnThatAccountWasSuccessfullyCreated()
        {
            string result = _person.CreateAccount();
            Assert.Equal("Account created sucess!", result);
        }

        [Fact]
        public void ShouldReturnThatAccountWasSuccessfullyClosed()
        {
            string result = _person.CloseAccount();
            Assert.Equal("Account close sucess!", result);
        }

    
    }
}