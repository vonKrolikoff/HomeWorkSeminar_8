// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите размеры матриц:");
int m = Input("Введите число строк: ");
int n = Input("Введите число столбцов: ");

int[,] firstMartrix = new int[m, n];
int[,] secondMartrix = new int[m, n];
int[,] composMatrix = new int[m, n];

Console.Clear();
PourArray(firstMartrix);
Console.WriteLine("Первая матрица:");
PrintArray(firstMartrix);
Console.WriteLine();

PourArray(secondMartrix);
Console.WriteLine("Вторая матрица:");
PrintArray(secondMartrix);
Console.WriteLine();

int Input(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void PourArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void PrintArray (int[,] array)
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

void ComposMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] composMatrix)
{
  for (int i = 0; i < composMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < composMatrix.GetLength(1); j++)
    {
      int summ = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        summ += firstMartrix[i,k] * secondMartrix[k,j];
      }
      composMatrix[i,j] = summ;
    }
  }
}

ComposMatrix(firstMartrix, secondMartrix, composMatrix);
Console.WriteLine("Произведение матриц:");
PrintArray(composMatrix); Console.WriteLine();