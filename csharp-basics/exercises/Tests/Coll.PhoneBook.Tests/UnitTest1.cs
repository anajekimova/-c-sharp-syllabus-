using Microsoft.VisualStudio.TestPlatform.TestHost;
using PhoneBook;
using System;
using Xunit;

namespace Coll.PhoneBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Number_GetNumber_ReturnGetNumber()
        {
            var name = "Nika";
            var number = 862229478;
            var expect = "862229478 - this number is owned by a Nika";
            var newNumber = new PhoneDirectory(name, number);

            var actual = newNumber.GetNumber(name);

            Assert.Equal(expect, actual);
        }

        [Fact]
        public void Number_PrintNameNumber_ReturnPrintNumber()
        {
            var name = "Nika";
            var number = 862229478;
            var expect = "862229478 - this number is owned by a Nika";
            var newNumber = new PhoneDirectory(name, number);

            var actual = newNumber.PrintNameNumber(name, number);

            Assert.Equal(expect, actual);
        }
    }
}
