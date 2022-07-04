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
    public class CalculatorFixture : IDisposable
    {
        public Calculator Calc => new Calculator();

        public void Dispose()
        {
            //Clean unwanted code and resources.
        }
    }

    public class CalculatorTest : IClassFixture<CalculatorFixture>, IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CalculatorFixture _calculatorFixture;
        private readonly MemoryStream memoryStream;
        public CalculatorTest (ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculatorFixture = calculatorFixture;
            _testOutputHelper.WriteLine("Constructor");
            memoryStream = new MemoryStream ();
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
            _testOutputHelper.WriteLine("FiboDoesNotIncludeZero");
            var calc = _calculatorFixture.Calc;
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]

        public void FiboIncludes13()
        {
            _testOutputHelper.WriteLine("FiboIncludes13");
            var calc = _calculatorFixture.Calc;
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]

        public void FiboIncludes4()
        {
            _testOutputHelper.WriteLine("FiboIncludes4");
            var calc = _calculatorFixture.Calc;
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]

        public void CheckCollection()
        {
            _testOutputHelper.WriteLine("Test starting at {0}", DateTime.Now);
            var expectedCollection = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            var calc = _calculatorFixture.Calc;
            _testOutputHelper.WriteLine("Asserting");
            Assert.Equal(expectedCollection, calc.FiboNumbers);
            _testOutputHelper.WriteLine("End");
        }

        //Without inLine "Theory" attribute
        //[Fact]
        //public void IsOdd_GivenOddValue_ReturnsTrue()
        //{
        //    var calc = new Calculator();
        //    var result = calc.IsOdd(1);
        //    Assert.Equal(true, result);
        //}

        //[Fact]
        //public void IsOdd_GivenEvenValue_ReturnsFalse()
        //{
        //    var calc = new Calculator();
        //    var result = calc.IsOdd(1);
        //    Assert.Equal(false, result);
        //}

        [Theory]
        [MemberData(nameof(TestDataShare.IsOddEvenData), MemberType = typeof(TestDataShare))]   
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var calc = new Calculator();
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(TestDataShare.IsEvenOddExternalData), MemberType = typeof(TestDataShare))]
        public void IsOdd_TestOddAndEvenExternal (int value, bool expected)
        {
            var calc = new Calculator();
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [IsOddOrEvenData]
        public void IsOdd_TestOddAndEvenExternalWithAttribute(int value, bool expected)
        {
            var calc = new Calculator();
            var result = calc.IsOdd(value);
            Assert.Equal(expected, result);
        }

        public void Dispose()
        {
            memoryStream.Close();  
        }
    }
}
 