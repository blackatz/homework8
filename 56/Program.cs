// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
//наименьшей суммой элементов: 1 строка

void CreateArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);
            if (j != input.GetLength(1) - 1)
                Console.Write(", ");
        }
        Console.WriteLine();
    }
}

int Summ(int[,] input, int i)
{
    int sum = input[i, 0];
    for (int j = 1; j < input.GetLength(1); j++)
    {
        sum = sum + input[i, j];
    }
    return sum;
}

Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int m = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];
CreateArray(array);
PrintArray(array);
Console.WriteLine();

int minsum = 0;
int sum = Summ(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
    int temp = Summ(array, i);
    if (sum > temp)
    {
        sum = temp;
        minsum = i;
    }
}

Console.WriteLine($"Строкa {minsum + 1} с наименьшей суммой = {sum}");