// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите количество строк 1-й матрицы: ");
int n = InputNumbers("Введите количество столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите количество столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] first = new int[m, n];
CreateArray(first);
Console.WriteLine($"Первая матрица:");
WriteArray(first);

int[,] secomd = new int[n, p];
CreateArray(secomd);
Console.WriteLine($"Вторая матрица:");
WriteArray(secomd);

int[,] result = new int[m,p];

MultiplyMatrix(first, secomd, result);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(result);

void MultiplyMatrix(int[,] first, int[,] secomd, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < first.GetLength(1); k++)
      {
        sum += first[i,k] * secomd[k,j];
      }
      result[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}