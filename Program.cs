
/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

/*Console.WriteLine("Specify the number of rows in the 2D array:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Specify the number of 2D array columns:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDArray = new double[m, n];
Random rnd = new Random();
void PrintArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}

void FillArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}}}
FillArray(twoDArray);
Console.WriteLine();
PrintArray(twoDArray);

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4
17 -> такого числа в массиве нет*/
/*
Console.WriteLine("Enter the line number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the column number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int [,] numbers = new int [3,4];
FillArrayRandomNumbers(numbers);

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 10);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write(" ");
        Console.WriteLine(""); 
    }
}

Console.WriteLine("");
if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine($"{n}{m} -> There is no such number in the array");
}
else
{
    Console.WriteLine($"The value of the element {n} row и {m} column -> {numbers[n-1,m-1]}");
}
Console.WriteLine("");*/

/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.WriteLine("Input numbers of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input numbers of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int[,] numbers = new int[user_rows, user_columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine("Arithmetic average of each column:");

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(" ");
        Console.WriteLine("");
    }
}

for (int j = 0; j < numbers.GetLength(1); j++)
{
    float avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / user_rows;
    Console.Write(avarage + "; ");
}
Console.WriteLine();




