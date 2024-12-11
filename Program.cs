using System.IO;

namespace Assignment6._4._1
{
    //You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).
    //You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.
    //DO NOT allocate another 2D matrix and do the rotation.

    internal class Program

    //---PSEUDO CODE
    //rotate the matrix 90 degrees clockwise
    //function RotateMatrix(matrix):
    //n = matrix.Length 
    // Number of rows/columns in the square matrix
    //1:transpose the matrix
    //for i = 0 to n - 1:
    //for j = i + 1 to n - 1:
    //swap matrix[i][j] with matrix[j][i]
    //temp = matrix[i][j]
    //matrix[i][j] = matrix[j][i]
    //matrix[j][i] = temp

    //2:reverse the rows
    //for i = 0 to n - 1:
    //left = 0
    //right = n - 1
    //while left<right:
    //Swap matrix[i][left] with matrix[i][right]
    //temp = matrix[i][left]
    //matrix[i][left] = matrix[i][right]
    //matrix[i][right] = temp

    //left = left + 1
    //right = right - 1
    {
        static void Main(string[] args)
        {
            //given matrix
            int[][] matrix = {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            Console.WriteLine("Given matrix:");
            PrintMatrix(matrix);

            RotateMatrix(matrix);

            Console.WriteLine("Rotated matrix:");
            PrintMatrix(matrix);
        }

        public static void RotateMatrix(int[][] matrix)
        {
            int n = matrix.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            for (int i = 0; i < n; i++)
            {
                int left = 0;
                int right = n - 1;
                while (left < right)
                {
                    int temp = matrix[i][left];
                    matrix[i][left] = matrix[i][right];
                    matrix[i][right] = temp;

                    left++;
                    right--;
                }
            }
        }
        public static void PrintMatrix(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
