using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestClasses;
using Xunit;

namespace AppTests
{
    public class FiboTest
    {
        [Fact]
        public void FiboDoesNotIncludeZero()
        {
            var calc = new Calculator();
            Assert.All(calc.FiboNumbers,n => Assert.NotEqual(0,n));
        }

        [Fact]
        public void FiboIncludes13()
        {
            var calc = new Calculator();
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        public void FiboIncludes4()
        {
            var calc = new Calculator();
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        public void CheckCollection()
        {
            var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            var calc = new Calculator();
            Assert.Equal(expectedCollection, calc.FiboNumbers);
        }
    }
}
