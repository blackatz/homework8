// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void Sort(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
         for (var j = 0; j < input.GetLength(1); j++)
        {
           for (int a = 0; a < input.GetLength(1)-1; a++)
        {
            if(input[i, a] < input[i, a+1])
            {
                int temp = input[i, a+1];
                input[i, a+1] = input[i, a];
                input[i, a] = temp;
            }
                
        }
        }
    }
}

Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
int m = int.Parse(Console.ReadLine()!);

int [,] array = new int[m, n];
CreateArray(array);
PrintArray(array);
Console.WriteLine();
Sort(array);
PrintArray(array);
