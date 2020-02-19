using System;
using Xunit;
using XUnitTesting;

namespace XUnitTesting
{
    public class Testing
    {
        Regestration r = new Regestration();

        //Using assert for first name when value is not null
        [Fact]
        public void firstName()
        {
            Assert.True(r.FirstName("Anjali"));
           
        }

        //Using assert for first name when value is null
        [Fact]
        public void FNull()
        {
            Assert.True(r.fname(" "));
        }

        //Using assert for last name when value is not null
        [Fact]
        public void lastName()
        {
            Assert.True(r.LastName("AAAbkad"));
        }

        //Using assert for last name when value is null
        [Fact]
        public void LNull()
        {
            Assert.True(r.lname(" "));
        }

        //Using assert for password when value is not null
        [Fact]
        public void Password()
        {
            Assert.True(r.password("anjaALI3"));
        }

        //Using assert for password when value is null
        [Fact]
        public void Passwrd()
        {
            Assert.True(r.passwrd(" "));
        }

        //Using assert for phone number when value is not null
        [Fact]
        public void Number()
        {
            Assert.True(r.PhNum("33720023"));
        }

        //Using assert for phone number when value is null
        [Fact]
        public void number()
        {
            Assert.True(r.mobile(" "));
        }

        //Using assert for email when value is not null
        [Fact]
        public void EMail()
        {
            Assert.True(r.Email("anjaliK19@gmail.com"));
        }

        //Using assert for email when value is null
        [Fact]
        public void Email()
        {
            Assert.True(r.mail(" "));
        }
    }
}
