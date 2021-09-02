using System;
using Xunit;

namespace Coll.WordCount.Tests
{
    public class UnitTest1
    {

        private string input =
            "Poor naked wretches, wheresoe'er you are,\n" +
            "That bide the pelting of this pitiless storm,\n" +
            "How shall your houseless heads and unfed sides,\n" +
            "Your loop'd and window'd raggedness, defend you \n" +
            "From seasons such as these? O, I have ta'en \n" +
            "Too little care of this!";

        [Fact]
        public void LineCount_Input_ExpectLineCount()
        {
            //Arrert
            var expect = "Line: 6";

            //Act
            var result = WordCount.WordLine(input);

            //Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void WordCount_Input_ExpectWordCount()
        {
            //Arrent
            var expect = "Word: 48";

            //Act
            var result = WordCount.CounWord(input);

            //Assert
            Assert.Equal(expect, result);
        }

        [Fact]
        public void CharCount_Input_ExpectCharCount()
        {
            //Arrent
            var expect = "Char: 258";

            //Act
            var result = WordCount.CharCount(input);

            //Assert
            Assert.Equal(expect, result);
        }
    }
}