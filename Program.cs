//Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
int InputNum(string message) //Ввод с клавиатуры
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols) //Создание двумерного массива
{
    return new int[rows, cols];
}

void Fill2DArray(int[,] array) //Заполнение двумерного массива
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(-100, 101);
}

void Print2DArray(int[,] array) //Вывод двумерного массива на экран
{
    //Console.Write("Ваш массив: \n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PoradokUbiv(int[,] array) //Сортировка по убыванию массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

Console.WriteLine($"Ваш массив: \n");
int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray);
Print2DArray(myArray);

Console.WriteLine($"Отсортированный массив: \n");
PoradokUbiv(myArray);
Print2DArray(myArray);
*/


//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int InputNum(string message) //Ввод с клавиатуры
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols) //Создание двумерного массива
{
    return new int[rows, cols];
}

void Fill2DArray(int[,] array) //Заполнение двумерного массива
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(-100, 101);
}

void Print2DArray(int[,] array) //Вывод двумерного массива на экран
{
    Console.Write("Ваш прямоугольный массив: \n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumRowsElems(int[,] array, int i) //Сумма элементов в строке
{
  int sum = array[i, 0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i, j];
  }
  return sum;
}

int rowscolumns = InputNum("Введите количество строк и столбцов: ");

int[,] myArray = Create2DArray(rowscolumns, rowscolumns);
Fill2DArray(myArray);
Print2DArray(myArray);

int minSumRows = 0;
int sumRows = SumRowsElems(myArray, 0);
for (int i = 1; i < myArray.GetLength(0); i++)
{
  int cloneSumRows = SumRowsElems(myArray, i);
  if (sumRows > cloneSumRows)
  {
    sumRows = cloneSumRows;
    minSumRows = i;
  }
}

Console.WriteLine($"\n{minSumRows+1} - строкa с наименьшей суммой ({sumRows}) элементов ");
*/

//Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

int InputNum(string message) //Ввод с клавиатуры
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols) //Создание двумерного массива
{
    return new int[rows, cols];
}

void Fill2DArray(int[,] array) //Заполнение двумерного массива
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(-100, 101);
}

void Print2DArray(int[,] array) //Вывод двумерного массива на экран
{
    //Console.Write("Ваш прямоугольный массив: \n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ProizvedArrays(int[,] firstArray, int[,] secondArray, int[,] resultArray) //Произведение матриц
{
  for (int i = 0; i < resultArray.GetLength(0); i++)
  {
    for (int j = 0; j < resultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i, k] * secondArray[k, j];
      }
      resultArray[i, j] = sum;
    }
  }
}

int rowsone = InputNum("Введите количество строк 1-й матрицы: ");
int columnsone = InputNum("Введите количество столбцов 1-й матрицы (и строк 2-й): ");
int columnsecond = InputNum("Введите количество столбцов 2-й матрицы: ");

Console.WriteLine($"Ваш первый массив: \n");
int[,] firstArray = Create2DArray(rowsone, columnsone);
Fill2DArray(firstArray);
Print2DArray(firstArray);

Console.WriteLine($"Ваш второй массив: \n");
int[,] secondArray = Create2DArray(columnsone, columnsecond);
Fill2DArray(secondArray);
Print2DArray(secondArray);

int[,] resultArray = Create2DArray(rowsone, columnsecond);

ProizvedArrays(firstArray, secondArray, resultArray);
Console.WriteLine($"Произведение первой и второй матрицы: \n");
Print2DArray(resultArray);