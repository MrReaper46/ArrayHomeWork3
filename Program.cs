using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create square array");
            Console.Write("Input size of square array: ");
            int SizeArray = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Size of Sqr.Array: {Math.Pow(SizeArray,2)}");
            int[,] Array01 = new int[SizeArray,SizeArray];
            Random rand = new Random();
            int total = 0;
            for (int row = 0; row < Array01.GetLength(0); row++)
            {
                for (int column = 0; column < Array01.GetLength(1); column++)
                {
                    Array01[row, column] = rand.Next(10,99);
                    Console.Write($"{Array01[row, column]} ");
                    if (row == column)
                    {
                        total += Array01[row, column]; 
                    }
                    else { continue; }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Total of Diagnal Values is: {total}");
        }
    }
}
