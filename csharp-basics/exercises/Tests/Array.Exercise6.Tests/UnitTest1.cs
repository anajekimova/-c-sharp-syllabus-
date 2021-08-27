using Exercise6;
using System;
using Xunit;

namespace Array.Exercise6.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int num = -7;
            int[] result = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] expect = { 1, 2, 3, 4, 5, 6, 7, 8, 9, -7 };

            int[] arr = Program.ChangeNumber(result);

            Assert.Equal(arr[9], num);
            for (var i = 0; i < 10; i++)
            {
                Assert.Equal(expect[i], arr[i]);
            }
        }
    }
}
