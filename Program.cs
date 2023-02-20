// двумерные массивы
// int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue) // размерность массива определяется количеством запятых int [,,] - 3х мерный массив 
// {
//     int[,] array = new int[rows, columns];
//     for(int i = 0; i<rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) // для GetLength если хотим взять количество строк, в скобках пишем (0), если количество столбцов, то (1)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
//         Console.WriteLine(); // для переноса строки
//     }
//     Console.WriteLine(); // чтобы таблицы не смешивались после вывода каждого массива
// }
// Console.Write("Input a number of rows: "); // генерация массива
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [,] newArray = CreateRandom2dArray(rows, columns, minValue, maxValue); // вывод на экран
// Show2dArray(newArray);
// Show2dArray(newArray);


// Все запросы запрашиваем через метод. Инициализируем данные прямо внутри метода:
// int [,] CreateRandom2dArray()  

// {
// Console.Write("Input a number of rows: "); // генерация массива
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a minimum value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a maximum value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int[rows, columns];
//     for(int i = 0; i<rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) // для GetLength если хотим взять количество строк, в скобках пишем (0), если количество столбцов, то (1)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
//         Console.WriteLine(); // для переноса строки
//     }
//     Console.WriteLine(); // чтобы таблицы не смешивались после вывода каждого массива
// }


// int [,] newArray = CreateRandom2dArray(); // вывод на экран
// Show2dArray(newArray);

// Итоговый вид гораздо изящнее. В круглых скобках ничего нет - аргументы не нужны

// Задачи для залов
// Задача 1
// НП генерация массива, каждый элемент формируется как сумма его индексов (метод генерирующий)
// на вход приходит кол-во строк и столбцов, возвращает - массив

//Задайте двумерный массив размера m на n, 
 //каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
 
//  int[,] FillArray(int rows, int columns)
//  {
//      int[,] matrix = new int[rows, columns];
//      for(int i=0; i<rows; i++)
//      {
//          for(int j=0; j<columns; j++)
//          {
//              matrix[i,j] = i+j; // основная формула
             
//          }
//      }
//      return matrix;
//  }
//  void PrintArray(int [,] matr)
//  {
//      for(int i=0; i<matr.GetLength(0); i++)
//      {
//          for(int j=0; j<matr.GetLength(1); j++)
//          {
//              Console.Write($"  {matr[i,j]}  ");
//          }
//      Console.WriteLine();
//      }
//  }
//  Console.Write("Input rows = ");
//  int rows = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Input columns = ");
//  int columns = Convert.ToInt32(Console.ReadLine());
//  int[,] matrix = FillArray(rows, columns);
  
//  PrintArray(matrix);


// Задача 2. Задать 2х мерный массив, найти элементы с четными индексами и заменить эти элементы на их квадраты (метод преобразующий)
// на вход - массив, ничего не возвращаем


//  int[,] FillArray(int rows, int columns)
//  {
//      int[,] matrix = new int[rows, columns];
//      for(int i=0; i<rows; i++)
//      {
//          for(int j=0; j<columns; j++)
//          {
//              matrix[i,j] = new Random().Next(1,10);
             
//          }
//      }
//      return matrix;
//  }
//  void PrintArray(int [,] matr)
//  {
//      for(int i=0; i<matr.GetLength(0); i++)
//      {
//          for(int j=0; j<matr.GetLength(1); j++)
//          {
//              Console.Write($"{matr[i,j]}  ");
//          }
//      Console.WriteLine();
//      }
//      Console.WriteLine();
//  }

//  void MakeKvadratEvenNumbers(int[,] array)
//  {
//      for (int i = 0; i< array.GetLength(0); i+=2)
//          for(int j = 0; j< array.GetLength(1); j+=2)
//              array[i,j] *= array[i,j];
//  }

//      Console.Write("Input number rows = ");
//      int rows = Convert.ToInt32(Console.ReadLine());
//      Console.Write("Input number columns = ");
//      int columns = Convert.ToInt32(Console.ReadLine());
//      int[,] array = FillArray(rows, columns);
//      PrintArray(array);
//      MakeKvadratEvenNumbers(array);
//      PrintArray(array);

 //----------------------------------------------------------------------------------
 //Задайте двумерный массив. Найдите сумму элементов, 
 //находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

 int[,] FillArray(int rows, int columns)
 {
     int[,] matrix = new int[rows, columns];
     for(int i=0; i<rows; i++)
     {
         for(int j=0; j<columns; j++)
         {
             matrix[i,j] = new Random().Next(1,10);

         }
     }
     return matrix;
 }
 void PrintArray(int [,] matr)
 {
     for(int i=0; i<matr.GetLength(0); i++)
     {
         for(int j=0; j<matr.GetLength(1); j++)
         {
             Console.Write($"{matr[i,j]}  ");
         }
     Console.WriteLine();
     }
     Console.WriteLine();
 }
 int SumElementMainDiagonal(int[,] array)
 {
     int sum = 0;
     for(int i=0; i<array.GetLength(0); i++)
     {
         {
             sum += array[i,i];
         }
     }
  return sum;
 }

     Console.Write("Input number rows = ");
     int rows = Convert.ToInt32(Console.ReadLine());
     Console.Write("Input number columns = ");
     int columns = Convert.ToInt32(Console.ReadLine());
     int[,] array = FillArray(rows, columns);
     PrintArray(array);
     int sum = SumElementMainDiagonal(array);
     Console.WriteLine($"Сумма элементов главной диагонали = {sum} ");


