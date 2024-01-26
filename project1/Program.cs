using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название массива, который вы хотите создать (OneDimensional; TwoDimensional; Jagged)");
            string arrayQuestion = Console.ReadLine();
            if (arrayQuestion == "OneDimensional")
            {
                Console.Write("Создать массив не случайно (Yes или No)? ");
                oneDimensionalArray array;
                if (Console.ReadLine() == "Yes")
                {
                    Console.Write("Введите длину массива: ");
                    array = new oneDimensionalArray(true, int.Parse(Console.ReadLine()));
                }
                else
                {
                    Console.Write("Введите длину массива: ");
                    array = new oneDimensionalArray(false, int.Parse(Console.ReadLine()));
                }
                Console.WriteLine("Что вы хотите вывести? Напишите average value, или Remove more than 100, или Remove duplicates, или Print array, или Пересоздать массив, или Stop для остановки: ");
                string question = Console.ReadLine();
                while (question != "Stop")
                {
                    if (question == "average value")
                    {
                        Console.WriteLine("Среднее значение: " + array.getAverageArrayValue());
                    }
                    else if (question == "Remove more than 100")
                    {
                        array.deleteBiggerThan100();
                        Console.WriteLine("Готово!");
                    }
                    else if (question == "Remove duplicates")
                    {
                        array.deleteRepeating();
                        Console.WriteLine("Готово!");
                    }
                    else if (question == "Print array")
                    {
                        array.printArray();
                    }
                    else if (question == "Пересоздать массив")
                    {
                        array.fillArray(false, 1);
                    }
                    Console.WriteLine("Что вы хотите вывести? Напишите average value, или Remove more than 100, или Remove duplicates, или Print array, или Пересоздать массив, или Stop для остановки: ");
                    question = Console.ReadLine();
                }

            }
            else if (arrayQuestion == "TwoDimensional")
            {
                Console.Write("Создать массив не случайно (Yes или No)? ");
                twoDimensionalArray array;
                if (Console.ReadLine() == "Yes")
                {
                    Console.Write("Введите длину массива: ");
                    int length = int.Parse(Console.ReadLine());
                    Console.Write("Введите ширину массива: ");
                    array = new twoDimensionalArray(true, length, int.Parse(Console.ReadLine()));
                }
                else
                {
                    Console.Write("Введите длину массива: ");
                    int length = int.Parse(Console.ReadLine());
                    Console.Write("Введите ширину массива: ");
                    array = new twoDimensionalArray(false, length, int.Parse(Console.ReadLine()));
                }
                Console.WriteLine("Что вы хотите вывести? Напишите average value, или Print even elements in reverse, или Print array, или Recreate the array, или Stop для остановки: ");
                string question = Console.ReadLine();
                while (question != "Stop")
                {
                    if (question == "average value")
                    {
                        Console.WriteLine("Среднее значение: " + array.getAverageTwoDimensionalArrayValue());
                    }
                    else if (question == "Print even elements in reverse")
                    {
                        array.getTwoDimensionalArrayAsSanke();
                        array.printTwoDimensionalArray();
                    }
                    else if (question == "Print array")
                    {
                        array.printTwoDimensionalArray();
                    }
                    else if (question == "Recreate the array")
                    {
                        array.fillArray(false, 1, 2);
                    }
                    Console.WriteLine("Что вы хотите вывести? Напишите average value, или Print even elements in reverse, или Print array, или Recreate the array, или Stop для остановки: ");
                    question = Console.ReadLine();
                }
            }
            else if (arrayQuestion == "Jagged")
            {
                Console.Write("Создать массив не случайно (Yes или No)? ");
                jagged array;
                if (Console.ReadLine() == "Yes")
                {
                    Console.Write("Введите длину массива: ");
                    array = new jagged(true, int.Parse(Console.ReadLine()));
                }
                else
                {
                    Console.Write("Введите длину массива: ");
                    array = new jagged(false, int.Parse(Console.ReadLine()));
                }
                Console.WriteLine("Что вы хотите вывести? Напишите average value, или Array Averages, или Change even to product, или Print array, или Recreate the array, или Stop для остановки: ");
                string question = Console.ReadLine();
                while (question != "Stop")
                {
                    if (question == "average value")
                    {
                        Console.WriteLine("Среднее значение: " + array.getAverageJaggedValue());
                    }
                    else if (question == "Array Averages")
                    {
                        double[] averageArray = array.getAverageArrayJaggedValue();
                        for (int i = 0; i < averageArray.Length; i++)
                        {
                            Console.Write(averageArray[i] + " ");
                        }
                        Console.WriteLine(" ");
                    }
                    else if (question == "Change even to product")
                    {
                        array.changeEvenInJagged();
                        Console.WriteLine("Готово!");
                    }
                    else if (question == "Print array")
                    {
                        array.printJagged();
                    }
                    else if (question == "Recreate the array")
                    {
                        array.fillArray(false, 1);
                    }
                    Console.WriteLine("Что вы хотите вывести? Напишите average value, или Array Averages, или Change even to product, или Print array, или Recreate the array, или Stop для остановки: ");
                    question = Console.ReadLine();
                }
            }
        }
    }
}