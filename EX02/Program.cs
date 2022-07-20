// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите размер массива mХn:");
int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] array = new int[m, n];
Console.Clear();
Console.WriteLine("Создан массив:");
PourArray(array);
PrintArray(array);
Console.WriteLine();

int minsumm = 0;
int summline = SumOfElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempsumm = SumOfElements(array, i);
  if (summline > tempsumm)
  {
    summline = tempsumm;
    minsumm = i;
  }
}
Console.WriteLine("Cтрокa с наименьшей суммой (" + (summline) + ") элементов: - строка №" + (minsumm+1));
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

int SumOfElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}