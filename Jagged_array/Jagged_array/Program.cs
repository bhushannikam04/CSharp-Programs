
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size of array");
            int sa = int.Parse(Console.ReadLine());
            int[][] arr = new int[sa][];
            for (int i = 0; i <= arr.Length; i++)
            {
                Console.WriteLine("enter the size of row");
                int rows=int.Parse(Console.ReadLine());
                arr[i] = new int[rows];
                for (int j = 0; j <= arr[i].Length; j++)         
                {
                    Console.WriteLine("Enter the values");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i=0; i<arr.Length; i++)
            {
                for(int j=0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");

                }

                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
