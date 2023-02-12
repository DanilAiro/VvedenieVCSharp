
//string[,] table = new string[2, 5];
// String.Empty;
// table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]

//table[1, 2] = "слово";

//for (int rows = 0; rows < 2; rows++)
//{
//  for (int columns = 0; columns < 5; columns++)
//  {
//    Console.WriteLine($"-{table[rows, columns]}-");
//  }
//}

//int[,] matrix = new int[3, 4];
//PrintArray(matrix);
//FillArray(matrix);
//PrintArray(matrix);


//for (int i = 0;i < 3; i++)
//{
//  for (int j = 0; j < 4; j++)
//  {
//    Console.Write($"{matrix[i, j]} ");
//  }
//  Console.WriteLine();
//}

//void PrintArray(int[,] matr)
//{

//  for (int i = 0; i < matr.GetLength(0); i++)
//  {
//    for (int j = 0; j < matr.GetLength(1); j++)
//    {
//      Console.Write($"{matr[i, j]} ");
//    }
//    Console.WriteLine();
//  }
//}

//void FillArray(int[,] matr)
//{
//  Random random = new Random();

//  for (int i = 0; i < matr.GetLength(0); i++)
//  {
//    for (int j = 0; j < matr.GetLength(1); j++)
//    {
//      matr[i, j] = random.Next(1, 10);
//    }
//  }
//}

//int[,] pic = new int[,]
//{
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//  {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
//  {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0},
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0},
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0},
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0},
//  {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0},
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
//};
//PrintImage(pic);
//FillImage(13, 13);
//PrintImage(pic);

//void PrintImage(int[,] img)
//{
//  for (int i = 0; i < img.GetLength(0); i++)
//  {
//    for (int j = 0; j < img.GetLength(1); j++)
//    {
//      if (img[i, j] == 0)
//        Console.Write($" ");
//      else
//        Console.Write($"+");
//    }
//    Console.WriteLine();
//  }
//}

//void FillImage(int row, int col)
//{
//  if (pic[row, col] == 0)
//  {
//    pic[row, col] = 1;
//    FillImage(row - 1, col);
//    FillImage(row, col - 1);
//    FillImage(row + 1, col);
//    FillImage(row, col + 1);
//  }
//}

//int Factorial(int number)
//{
//  if (number == 1)
//    return 1;
//  else return number * Factorial(number - 1);
//}

//for (int i = 1; i < 40; i++)
//{
//  Console.WriteLine(Factorial(i));

//}


double Fibonacci(int number)
{
  if (number == 1 || number == 2)
    return 1;
  else
    return Fibonacci(number - 1) + Fibonacci(number - 2);
}

for (int i = 1; i < 10; i++)
{
  Console.WriteLine(Fibonacci(i));
}