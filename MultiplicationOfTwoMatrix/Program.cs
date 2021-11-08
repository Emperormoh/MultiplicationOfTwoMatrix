using System;

namespace MultiplicationOfTwoMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] firstMatrix = {
                {5, 6, 1},
                {0, -2, 1},
                {2, 1, 2}
            };

            int[,] secondMatrix = {
                {-2, 4, 3},
                {3, 2, 5},
                {-1, 4, 2}
            };

            void multiplyMatrix(int[,] matrix1, int[,] matrix2)
            {
                //Get the number of rows and columns of the two matrices
                int matrix1_row = matrix1.GetLength(0);
                int matrix1_column = matrix1.GetLength(1);
                int matrix2_row = matrix2.GetLength(0);
                int matrix2_column = matrix2.GetLength(1);

                //Check if matrices get be multiplied...matrices can be multiplied if the first matrix number of columns equals second matrice number of rows
                if (matrix1_column != matrix2_row)
                {
                    Console.WriteLine("The two matrices cannot be multiplied");
                }
                else
                {

                    int[,] matrixFormed = new int[matrix1_row, matrix2_column];

                    // Multiply the two matrices together
                    for (int i = 0; i < matrix1_row; i++)
                    {
                        for (int j = 0; j < matrix2_column; j++)
                        {
                            for (int k = 0; k < matrix2_row; k++)
                            {
                                matrixFormed[i, j] = matrixFormed[i, j] + matrix1[i, k] * matrix2[k, j];
                            }
                        }
                    }

                    Console.WriteLine("THE PRODUCT OF THE TWO MATRICES: ");
                    for (int i = 0; i < matrix1_row; i++)
                    {
                        for (int j = 0; j < matrix2_column; j++)
                        {
                            Console.Write(matrixFormed[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }

            //Call multiplyMatrix function with the two matrices to be multiplied
            multiplyMatrix(firstMatrix, secondMatrix);

        }
    }
}
