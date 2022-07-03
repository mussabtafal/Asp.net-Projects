using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestClasses;
using Xunit;

namespace AppTests
{
    public class NameTest
    {
        [Fact]
        public void MakeFullNameTest()
        {
            var names = new Names();
            var result = names.MakeFullName("Mussab", "Taffal");
            //Assert.Equal("Mussab Taffal", result, ignoreCase:true);
            //Assert.Contains("ussa", result, StringComparison.InvariantCultureIgnoreCase);
            //Assert.StartsWith("mussab", result);
            //Assert.EndsWith("taffal", result);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var names = new Names();
            names.NickName = "Test";
            //Assert.Null(names.NickName);
            Assert.NotNull(names.NickName);
        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var names = new Names();
            var result = names.MakeFullName("Mussab", "Taffal");
            Assert.NotNull(result);
            Assert.False(string.IsNullOrEmpty(result));
        }
    }
}
