// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine("Введите размер массива X x Y x Z:");
int x = Input("Введите X: ");
int y = Input("Введите Y: ");
int z = Input("Введите Z: ");

Console.Clear();
int[,,] arrayX = new int[x, y, z];
PourArray(arrayX);
PrintArray(arrayX);

int Input(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void PrintArray (int[,,] array3D)
{
  for (int i = 0; i < arrayX.GetLength(0); i++)
  {
    for (int j = 0; j < arrayX.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < arrayX.GetLength(2); k++)
      {
        Console.Write($"Z({k})={arrayX[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void PourArray(int[,,] arrayX)
{
  int[] temp = new int[arrayX.GetLength(0) * arrayX.GetLength(1) * arrayX.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arrayX.GetLength(0); x++)
  {
    for (int y = 0; y < arrayX.GetLength(1); y++)
    {
      for (int z = 0; z < arrayX.GetLength(2); z++)
      {
        arrayX[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
