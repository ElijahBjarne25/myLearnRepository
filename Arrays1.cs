using System;
using System.Linq;

namespace lessons
{

    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * 1. Заполнить массиы с клавиатуры
             * 2. вывести массив в обратном порядке
             * 3. найти сумму четных чисел в массиве
             * 4. найти наименьшее число в массиве
             */

            // NUM 1.

            Console.Write("Enter the number of elements of the array: ");
            int n1 = int.Parse(Console.ReadLine());
            int[] array1 = new int [n1];

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("Enter the " + i + " index of the array: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Final array: ");

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(" " + array1[i]);
            }

            Console.WriteLine("\n");

            // NUM 2. 

            int[] array2 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            Console.WriteLine("Initial array:");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(" " + array2[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Final array:");
            for (int i = array2.Length - 1; i >= 0 ; i--)
            {
                Console.Write(" " + array2[i]);
            }

            Console.WriteLine("\n");

            // NUM 3.

            int[] array3 = { 10, 2, 3, 1, 0 };
            int evensum = 0;

            Console.WriteLine("Initial array:");
            for (int i = 0; i < array3.Length; i++)
            {
                Console.Write(" " + array3[i]);
            }
            Console.WriteLine("");

            for (int i = 0; i < array3.Length; i++)
            {
                if (array3[i] % 2 == 0)
                {
                    evensum += array3[i];
                }
            }
            Console.WriteLine("Sum of even numbers in an array: " + evensum + "\n");

            // NUM 4.

            int[] array4 = { 5, 7, 190, 222, 3, 12 };
            int minValue = array4[0];

            Console.WriteLine("Initial array:");
            for (int i = 0; i < array4.Length; i++)
            {
                Console.Write(" " + array4[i]);
            }
            Console.WriteLine("");

            for (int i = 1; i < array4.Length; i++)
            {
                if (array4[i] < minValue)
                {
                    minValue = array4[i];
                }
            }
            Console.WriteLine("Min value: " + minValue);
        }
    }
}
