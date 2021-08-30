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
        public void Line_CountWordLine_ReturnWordLine()
        {
            var expect = "Line: 6";
            var result = WordCount.WordLine(input);

            Assert.Equal(expect, result);
        }

        [Fact]
        public void Word_CountWordWords_ReturnWordWords()
        {
            var expect = "Word: 48";
            var result = WordCount.CounWord(input);

            Assert.Equal(expect, result);
        }

        [Fact]
        public void Char_CountWordChar_ReturnWordChar()
        {
            var expect = "Char: 258";
            var result = WordCount.CharCount(input);

            Assert.Equal(expect, result);
        }
    }
}