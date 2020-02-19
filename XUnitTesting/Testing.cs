using System;
using Xunit;
using XUnitTesting;

namespace XUnitTesting
{
    public class Testing
    {
        Regestration r = new Regestration();

        [Fact]
        public void firstName()
        {
            Assert.True(r.FirstName("Anjali"));
           
        }
        [Fact]
        public void lastName()
        {
            Assert.True(r.LastName("AAAbkad"));
        }
        [Fact]
        public void Password()
        {
            Assert.True(r.password("anjaALI3"));
        }
        [Fact]
        public void Number()
        {
            Assert.True(r.PhNum("33720023"));
        }
        [Fact]
        public void EMail()
        {
            Assert.True(r.Email("anjaliK19@gmail.com"));
        }
    }
}
