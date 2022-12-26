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
