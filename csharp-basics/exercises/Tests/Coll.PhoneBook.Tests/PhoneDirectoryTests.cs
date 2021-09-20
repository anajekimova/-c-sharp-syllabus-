using Microsoft.VisualStudio.TestPlatform.TestHost;
using PhoneBook;
using System;
using Xunit;

namespace Coll.PhoneBook.Tests
{
    public class PhoneDirectoryTests
    {
        [Fact]
        public void FindNumberByName_Name_ExpectFindNameAndNumber()
        {
            //Arrange
            var name = "Nika";
            var number = 862229478;
            var expect = "862229478 - this number is owned by a Nika";
            var newNumber = new PhoneDirectory(name, number);

            //Act
            var actual = newNumber.GetNumber(name);

            //Assert
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void AddNumber_AddNameNumber_ExpectPrintNameAndNamber()
        {
            //Arrange
            var name = "Nika";
            var number = 862229478;
            var expect = "862229478 - this number is owned by a Nika";
            var newNumber = new PhoneDirectory(name, number);

            //Act
            var actual = newNumber.PrintNameNumber(name, number);

            //Assert
            Assert.Equal(expect, actual);
        }
    }
}
