using System;

namespace Lesson5_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество строк матрицы 1");
            int stringMatrixA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите колличество столбцов матрицы 1");
            int columMatrixA = Convert.ToInt32(Console.ReadLine());
            //Создаю матрицу
            int[,] matrixA = CrieteMatrix(stringMatrixA, columMatrixA);
            Console.WriteLine("Матрица 1");
            //Вывожу первую матрицу
            PrintMatrix(matrixA);

            Console.WriteLine("Введите колличество строк матрицы 2");
            int stringMatrixB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите колличество столбцов матрицы 2");
            int columMatrixB = Convert.ToInt32(Console.ReadLine());
            //Создаю матрицу
            int[,] matrixB = CrieteMatrix(stringMatrixB, columMatrixB);
            Console.WriteLine("Матрица 2");
            //Вывожу вторую матрицу
            PrintMatrix(matrixB);

            int[,] matrixC = new int[stringMatrixA, columMatrixA];

            Console.WriteLine("Какую операцию вы хотите выполнить?");

            bool correctNumber = false;
            //Получаю от пользователя выбраный метод
            int methodNumber = GetMetodNumber();

            switch (methodNumber)
            {
                //Умножает на число
                case 1:
                    while (correctNumber == false)
                    {
                        Console.WriteLine("Какую матрицу вы хотите умножить? 1 или 2");
                        string matrixNuber = Console.ReadLine();
                        if (matrixNuber == "1")
                        {
                            matrixC = MultiplyMatrixByNumber(matrixA);
                            Console.WriteLine("Результат умнажения на число");
                            PrintMatrix(matrixC);
                            correctNumber = true;
                        }
                        else if (matrixNuber == "2")
                        {
                            matrixC = MultiplyMatrixByNumber(matrixB);
                            correctNumber = true;
                            Console.WriteLine("Результат умнажения на число");
                            PrintMatrix(matrixC);
                        }
                        else
                        {
                            Console.WriteLine("Введенно не правельное число");
                        }
                    }
                    break;
                //Складывает матрицы
                case 2:
                    bool addMatrix = false;                   
                    
                    while (addMatrix == false)
                    {
                        addMatrix = IsAddMatrix(matrixA, matrixB);

                        if (addMatrix == true)
                        {
                            matrixC = AddMatrices(matrixA, matrixB);
                        }
                        else
                        {
                            Console.WriteLine("Число строк и столбцов 1ой и 2 ой матрицы должны быть равны");
                            Console.WriteLine("Ведите число строк 2ой матрицы");
                            int stringMatrixNew = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ведите число столбцов 2ой матрицы");
                            int columngMatrixNew = Convert.ToInt32(Console.ReadLine());
                            matrixB = CrieteMatrix(stringMatrixNew, columngMatrixNew);
                            Console.WriteLine("Матрица 2");
                            PrintMatrix(matrixB);
                        }
                    }
                    Console.WriteLine("Результат сложения");
                    PrintMatrix(matrixC);
                    break;
                    //Умножение матриц
                case 3:
                    matrixC = MultiplyMatrix(matrixA,matrixB);
                    Console.WriteLine("Результат умножения");
                    PrintMatrix(matrixC);
                    break;
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Создание рандомно двумерной матрицы с заданым количеством строк и столбцов 
        /// </summary>
        /// <param name="numberStringMatrix">Число строк</param>
        /// <param name="numberColumnMatrix">Число столбцов</param>
        /// <returns>Возвращает матрицу</returns>
        static int[,] CrieteMatrix(int numberStringMatrix, int numberColumnMatrix)
        {
            int[,] matrix = new int[numberStringMatrix, numberColumnMatrix];
            Random random = new Random();

            for (int i = 0; i < numberStringMatrix; i++)
            {
                for (int j = 0; j < numberColumnMatrix; j++)
                {
                    matrix[i, j] = random.Next(10);
                }
            }

            return matrix;
        }

        /// <summary>
        /// Метод отображает матрицу в консоли
        /// </summary>
        /// <param name="matrix">Матрица</param>
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Умнежение матрицы на число
        /// </summary>
        /// <param name="matrix">Исходная матрица</param>        
        /// <returns>Возврощает матрицу</returns>
        static int[,] MultiplyMatrixByNumber(int[,] matrix)
        {
            Console.WriteLine("Введите число на которое нужно умножить матрицу");
            int number = Convert.ToInt32(Console.ReadLine());
            int[,] resultMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = matrix[i, j] * number;
                }
            }
            return resultMatrix;
        }
        /// <summary>
        /// Складывает матрицы
        /// </summary>
        /// <param name="matrices1">Матрица 1</param>
        /// <param name="matrices2">Матрица 2</param>
        /// <returns>Вовращает матрицу</returns>
        static int[,] AddMatrices(int[,] matrices1, int[,] matrices2)
        {
            
            int[,] resultMatrix = new int[matrices1.GetLength(0),matrices1.GetLength(1)];         
                           
                for (int i = 0; i < resultMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < resultMatrix.GetLength(1); j++)
                    {
                        resultMatrix[i, j] = matrices1[i, j] + matrices2[i, j];

                    }
                }            

                return resultMatrix;            
        }
        /// <summary>
        /// Проверяте знчение для выбора метода
        /// </summary>
        /// <returns>Возвращаяет число</returns>
        static int GetMetodNumber()
        {
            int methodNumber = 0;
            bool flag = false;
            while (flag == false)
            {
                Console.WriteLine("Для умножения на число нжмите 1 \nДля сложения матриц нажмите 2 \nДля умножения матриц нажмите 3");
                methodNumber = Convert.ToInt32(Console.ReadLine());
                if (methodNumber==1 || methodNumber==2 || methodNumber==3)
                {
                    flag = true;
                    
                }
                else
                {
                    flag = false;
                    Console.WriteLine("Такого значения нет");
                }
            }
            return methodNumber;
        }
        /// <summary>
        /// Метод умножения матриц
        /// </summary>
        /// <param name="matrix1">Матрица 1</param>
        /// <param name="matrix2">Матрица 2</param>
        /// <returns>Возвращает матрицу</returns>
        static int [,] MultiplyMatrix(int [,] matrix1, int [,] matrix2)
        {
            bool checkMatrix = IsMultiplyMatrixB(matrix1, matrix2);
            int[,] newMatrix=new int [matrix1.GetLength(0),matrix2.GetLength(1)];

            if (checkMatrix==true)
            {
                newMatrix = matrix2;
            }
            else
            {
                while (checkMatrix == false)
                {
                    Console.WriteLine("Колличество строк не равно колличеству столбцов 1-ой матрцы");
                    Console.WriteLine("Введите колличество строк матрицы 2");
                    int matrixString = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите колличество столбцов матрицы 2");
                    int matrixColumn = Convert.ToInt32(Console.ReadLine());
                    newMatrix = CrieteMatrix(matrixString, matrixColumn);

                    bool flag = IsMultiplyMatrixB(matrix1, newMatrix);

                    checkMatrix = flag;

                }
            }

            int[,] resultMatrix = new int[matrix1.GetLength(0), newMatrix.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < newMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < newMatrix.GetLength(0); k++)
                    {
                        resultMatrix[i, j] += matrix1[i, k] * newMatrix[k, j];
                    }
                }

            }

            return resultMatrix;
        }
        /// <summary>
        /// Проверяет колличество строк второй матрицы с колличество столбцов первой матрицы
        /// </summary>
        /// <param name="matrixA">Матрица 1</param>
        /// <param name="matrixB">Матрица 2</param>
        /// <returns>Возвращает булевое знчение</returns>
        static bool IsMultiplyMatrixB(int[,] matrixA, int[,] matrixB)
        {
            bool doesTheMatrixMatch = false;

            if (matrixB.GetLength(0) != matrixA.GetLength(1))
            {
                doesTheMatrixMatch = false;
            }
            else
            {
                doesTheMatrixMatch = true;
            }

            return doesTheMatrixMatch;
        }
        /// <summary>
        /// Проверяет число строк истолбцов двух матриц
        /// </summary>
        /// <param name="matrixA">Матрица 1</param>
        /// <param name="matrixB">Матрица 2</param>
        /// <returns>Возвращает булевое значение</returns>
        static bool IsAddMatrix(int[,] matrixA, int [,] matrixB)
        {
            bool addMatrix=false;
            if (matrixA.GetLength(0)==matrixB.GetLength(0) & matrixA.GetLength(1)==matrixB.GetLength(1))
            {
                addMatrix = true;
            }
            else
            {
                addMatrix = false;
            }
            return addMatrix;
        }
    }
}

