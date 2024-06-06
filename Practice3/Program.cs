using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[,] matrixA = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int[,] matrixB = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

            int rowsA = matrixA.GetLength(0);
            int colsA = matrixA.GetLength(1);
            int colsB = matrixB.GetLength(1);

            int[,] resultMatrix = new int[rowsA, colsB];
            Task<int>[,] tasks = new Task<int>[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    int row = i;
                    int col = j;
                    tasks[i, j] = Task.Run(() =>
                    {
                        int sum = 0;
                        for (int k = 0; k < colsA; k++)
                        {
                            sum += matrixA[row, k] * matrixB[k, col];
                        }
                        return sum;
                    });
                }
            }

            Task.WhenAll(tasks.Cast<Task>()).Wait();

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    resultMatrix[i, j] = tasks[i, j].Result;
                }
            }

            Console.WriteLine("Result Matrix:");
            PrintMatrix(resultMatrix);

            Console.ReadKey();
        }


        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
