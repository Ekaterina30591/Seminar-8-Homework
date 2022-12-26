//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minimum possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maximum possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }

    Console.WriteLine();
}

void OrderinRows (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = 0; x < array.GetLength(1) - 1; x++)
            {
            if (array[i, x] < array[i, x + 1])
                {
                    int temp = array[i, x + 1];
                    array[i, x + 1] = array[i, x];
                    array[i, x] = temp;
                }
            }
        }
    }
}

int[,]myArray = CreateRandom2dArray();
Show2dArray(myArray);
OrderinRows(myArray);
Show2dArray(myArray);
*/
/*
//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRandom2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minimum possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maximum possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }

    Console.WriteLine();
}

int SumRowElements(int[,] array, int i)
{
  int sumRow = array[i,0];

  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRow += array[i,j];
  }
  return sumRow;
}

int MinSumRow (int[,] array)
{
int minSumRow = 0;
int sumRow = SumRowElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumRow = SumRowElements(array, i);
  if (sumRow > tempSumRow)
  {
    sumRow = tempSumRow;
    minSumRow = i;
  }
}
return minSumRow;
}

int[,]myArray = CreateRandom2dArray();
Show2dArray(myArray);
int minimumSumRow = MinSumRow(myArray) + 1;
Console.WriteLine($"Row with minimum sum is {minimumSumRow}");
*/
/*
//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.

Console.Write("Input number of rows in 1st matrix: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns in 1st matrix (=number of rows in 2nd matrix): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns in 2nd matrix: ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimum possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximum possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2dArray1()
{
    
    int[,] array1 = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array1[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array1;
}
int[,] CreateRandom2dArray2()
{
   
    int[,] array2 = new int[n, p];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < p; j++)
        {
            array2[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array2;
}

void Show2dArray1(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
            Console.Write(array1[i,j] + "\t");

        Console.WriteLine();
    }

    Console.WriteLine();
}

void Show2dArray2(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for(int j = 0; j < array2.GetLength(1); j++)
            Console.Write(array2[i,j] + "\t");

        Console.WriteLine();
    }

    Console.WriteLine();
}

int[,] resultMatrix = new int[m,p];

void MultiplyMatrix(int[,] array1, int[,] array2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void ShowResultMatrix (int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < resultMatrix.GetLength(1); j++)
            Console.Write(resultMatrix[i,j] + "\t");

        Console.WriteLine();
    }

    Console.WriteLine();
}

Console.WriteLine("First matrix: ");
int[,]myArray1 = CreateRandom2dArray1();
Show2dArray1(myArray1);
Console.WriteLine("Second matrix: ");
int[,]myArray2 = CreateRandom2dArray2();
Show2dArray2(myArray2);
Console.WriteLine("Multiplied matrix: ");
MultiplyMatrix(myArray1, myArray2, resultMatrix);
ShowResultMatrix(resultMatrix);

*/
/*
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Write("Enter number of rows and columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = new int[n, n];

int count = 1;
int i = 0;
int j = 0;

while (count <= myArray.GetLength(0) * myArray.GetLength(1))
{
  myArray[i, j] = count;
  count++;
  if (i <= j + 1 && i + j < myArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= myArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > myArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }

    Console.WriteLine();
}

Show2dArray(myArray);
*/