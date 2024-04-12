using System;

namespace App // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter the number of lines: ");
      int m = int.Parse(Console.ReadLine() ?? "");
      Console.Write("Enter the number of columns: ");
      int n = int.Parse(Console.ReadLine() ?? "");
      Console.WriteLine();

      int[,] mat = new int[m, n];
      for (int i = 0; i < m; i++)
      {
        string[] values = Console.ReadLine()!.Split(' ');
        for (int j = 0; j < n; j++)
        {
          mat[i, j] = int.Parse(values[j]);
        }
      }

      Console.WriteLine();
      Console.Write("Enter a number x: ");
      int x = int.Parse(Console.ReadLine() ?? "");

      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          if (mat[i, j] == x)
          {
            Console.WriteLine();
            Console.WriteLine($"Position: Linha: {i}, Coluna: {j}");
            if (j > 0) Console.WriteLine($"Left of {x}: {mat[i, j - 1]}");
            if (j + 1 < mat.GetLength(1)) Console.WriteLine($"Right of {x}: {mat[i, j + 1]}");
            if (i + 1 < mat.GetLongLength(0)) Console.WriteLine($"Down of {x}: {mat[i + 1, j]}");
            if (i > 0) Console.WriteLine($"Up of {x}: {mat[i - 1, j]}");
            Console.WriteLine();
          }
        }
      }

    }
  }
}