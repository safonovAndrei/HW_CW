using System;

namespace project1
{
    class twoDimensionalArray
    {
        private int[,] array;

        public twoDimensionalArray(bool isNotRandom, int arrayLength, int arrayWidth)
        {
            if (isNotRandom)
            {
                array = new int[arrayWidth, arrayLength];
                GetTwoDimensionalArray(array);
            }
            else
            {
                Random random = new Random();
                int ArrayLength = random.Next(3, 10);
                int ArrayWidth = random.Next(3, 10);
                array = new int[ArrayWidth, ArrayLength];
                GetTwoDimensionalArrayRandom(array);
            }
        }

        private int[,] GetTwoDimensionalArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }

        private int[,] GetTwoDimensionalArrayRandom(int[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 10);
                }
            }
            return array;
        }

        public void fillArray(bool isNotRandom, int arrayLength, int arrayWidth)
        {
            Console.Write("Пересоздать массив не случайно (Да или Нет)? ");
            int[,] array;
            if (Console.ReadLine() == "Да")
            {
                Console.Write("Введите длину массива: ");
                arrayLength = int.Parse(Console.ReadLine());
                Console.Write("Введите ширину массива: ");
                arrayWidth = int.Parse(Console.ReadLine());
                isNotRandom = true;
            }
            else
            {
                Console.Write("Введите длину массива: ");
                arrayLength = int.Parse(Console.ReadLine());
                Console.Write("Введите ширину массива: ");
                arrayWidth = int.Parse(Console.ReadLine());
                isNotRandom = false;
            }
            if (isNotRandom)
            {
                array = new int[arrayWidth, arrayLength];
                GetTwoDimensionalArray(array);
            }
            else
            {
                Random random = new Random();
                int ArrayLength = random.Next(3, 10);
                int ArrayWidth = random.Next(3, 10);
                array = new int[ArrayWidth, ArrayLength];
                GetTwoDimensionalArrayRandom(array);
            }
        }
        
        public int getAverageTwoDimensionalArrayValue()
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum / array.Length;
        }

        public int[,] getTwoDimensionalArrayAsSanke()
        {
            int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        newArray[i, j] = array[i, j];
                    }
                    else
                    {
                        newArray[i, j] = array[i, array.GetLength(1) - j - 1];
                    }
                }
            }
            array = newArray;
            return newArray;
        }

        public void printTwoDimensionalArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
