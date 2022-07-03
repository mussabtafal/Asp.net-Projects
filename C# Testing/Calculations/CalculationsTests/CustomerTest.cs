using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestClasses;
using Xunit;

namespace AppTests
{
    public class CustomerTest
    {
        [Fact]
        public void CheckNameNotEmpty()
        {
            var customer = new Customer();
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }

         
        [Fact]
        public void CheckLegitForDiscount()
        {
            var customer = new Customer();
            Assert.InRange(customer.Age, 25, 40);
        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var customer = new Customer();
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(""));
            Assert.Equal("Hello", exceptionDetails.Message);
        }
    }
}
