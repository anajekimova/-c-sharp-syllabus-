using System;
using Xunit;

namespace Exercise6.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Loza_Number_ExpectLoza()
        {
            //Arrange
            var expect = "Loza";

            //Act
            var result = Program.ColoLoza(10);

            //Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void Coza_Number_ExpectCoza()
        {
            //Arrange
            var expect = "Coza";

            //Act
            var result = Program.ColoLoza(9);
            
            //Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void ColoLoza_Number_ExpectColoLoza()
        {
            //Arrange
            var expect = "Woza";

            //Act
            var result = Program.ColoLoza(14);

            //Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void CozaLoza_Number_ExpectCOzaLoza()
        {
            //Arrange
            var expect = "CozaLoza";

            //Act
            var result = Program.ColoLoza(15);

            //Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void ItNumber_Number_ExpectItNumber()
        {
            //Arrange
            var expect = "29";

            //Act
            var result = Program.ColoLoza(29);

            //Assert
            Assert.Equal(expect, result);
        }       
    }
}
