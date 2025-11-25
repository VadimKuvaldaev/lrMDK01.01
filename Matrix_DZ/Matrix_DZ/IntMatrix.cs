using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_DZ
{
    public class IntMatrix
    {
        private int[,] matrix; // int[,] - двумерный массив, массив со строками и столбцами

        public int Rows { get; }
        public int Columns { get; }
        public bool IsSquare => Rows == Columns;

        public IntMatrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            matrix = new int[rows, columns];
        }

        // Установить значение
        public void SetValue(int rows, int columns, int value)
        {
            matrix[rows, columns] = value;
        }

        // Получить значение
        public int GetValue(int rows, int columns)
        {
            return matrix[rows, columns];
        }

        // Определитель для квадратной матрицы
        public int Determinant()
        {
            if (!IsSquare)
                Console.WriteLine("Матрица должна быть квадратной");

            if (Rows == 1) return matrix[0, 0];
            if (Rows == 2) return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            if (Rows == 3) return Determinant3x3();         
        }

        private int Determinant3x3()
        {
            return matrix[0, 0] * matrix[1, 1] * matrix[2, 2] +
                   matrix[0, 1] * matrix[1, 2] * matrix[2, 0] +
                   matrix[0, 2] * matrix[1, 0] * matrix[2, 1] -
                   matrix[0, 2] * matrix[1, 1] * matrix[2, 0] -
                   matrix[0, 1] * matrix[1, 0] * matrix[2, 2] -
                   matrix[0, 0] * matrix[1, 2] * matrix[2, 1];
        }

        // Умножение матриц
        public static IntMatrix Multiply(IntMatrix a, IntMatrix b)
        {
            if (a.Columns != b.Rows)
                Console.WriteLine("Несовместимые размеры матриц");

            IntMatrix result = new IntMatrix(a.Rows, b.Columns);

            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < b.Columns; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < a.Columns; k++)
                    {
                        sum += a.GetValue(i, k) * b.GetValue(k, j);
                    }
                    result.SetValue(i, j, sum);
                }
            }

            return result;
        }

        // Вывод матрицы
        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
