using Calculations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestClasses;
using Xunit;
using Xunit.Abstractions;

namespace AppTests
{
    public class CalculatorFixture
    {
        public Calculator Calc => new Calculator();
    }

    public class CalculatorTest : IClassFixture<CalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CalculatorFixture _calculatorFixture;
        private readonly MemoryStream memoryStream;
        public CalculatorTest (ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculatorFixture = calculatorFixture;
            _testOutputHelper.WriteLine("Constructor");
        }

        [Fact]
        public void Add_DivenTwoIntValues_ReturnsInt()
        {
            var calc = new Calculator();
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }
        
        [Fact]
        public void AddDouble_DivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.23, 3.55);
            Assert.Equal(4.78, result, 1);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            var calc = _calculatorFixture.Calc;
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]

        public void FiboIncludes13()
        {
            var calc = _calculatorFixture.Calc;
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]

        public void FiboIncludes4()
        {
            var calc = _calculatorFixture.Calc;
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]

        public void CheckCollection()
        {
            var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            var calc = _calculatorFixture.Calc;
            Assert.Equal(expectedCollection, calc.FiboNumbers);
        }
    }
}
 