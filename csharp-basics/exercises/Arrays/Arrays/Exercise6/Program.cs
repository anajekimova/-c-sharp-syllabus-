using System;

namespace Exercise6
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = RandomNumber();
            int[] array1 = ChangeNumber(array);

            Console.Write("Array 1:");
            for (var i = 0; i < 10; i++)
            {
                Console.Write(" " + array[i]);
            }

            Console.WriteLine();
            Console.Write("Array 2:");
            for (var j = 0; j < 10; j++)
                Console.Write(" " + array1[j]);

            Console.ReadKey();
        }

        public static int[] RandomNumber()
        {
            Random randName = new Random();
            int[] arry = new int[10];

            for (int i = 0; i < 10; i++)
            {
                arry[i] = randName.Next(100);               
            }

            return arry;
        }

        public static int[] ChangeNumber(int [] arry)
        {
            int[] newArr = new int[10];
            newArr[9] = -7;
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arry[i];
            }

            newArr[9] = -7;
            return newArr;
        }
    }
}