using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# Sharp program for adding two matrices of the same size.
            int[,] mat1 =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            int[,] mat2 =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            int[,] mat3 = new int[mat1.GetLength(0), mat1.GetLength(1)];
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    mat3[i, j] = mat1[i, j] + mat2[i, j];
                }
            }
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(1); j++)
                {
                    Console.Write(mat3[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


            
