using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeComplexity
{
  class Program
  {
    static void Main(string[] args)
    {
      //int X = 10;
      //int Y = 85;
      //int D = 30;
      //int result = Solution(X, Y, D);

      //int[] A = new int[] { 2, 3, 1, 4 };
      //int result = PermMissingElem(A);

      int[] A = new int[] { 3, 1, 2, 4, 3 };
      //int[] A = new int[] { 3, 2003 };
      int result = TapeEquilibrium(A);
    }


    public static int TapeEquilibrium(int[] A)
    {
      int minimal = 0;
      int partOne = A[0];
      int partTwo = A.Skip(1).Take(A.Count() - 1).ToArray().Sum();
      minimal = Math.Abs(partOne - partTwo);
      if (A.Count() > 2)
      {
        for (int p = 1; p < A.Count() - 1; p++)
        {
          partOne += A[p];
          partTwo -= A[p];
          if (minimal > Math.Abs(partOne - partTwo))
          {
            minimal = Math.Abs(partOne - partTwo);
          }
        }
      }

      return minimal;
    }


    public static int Solution(int X, int Y, int D)
    {
      // write your code in C# 6.0 with .NET 4.5 (Mono)
      if (X == Y || D == 0)
      {
        return 0;
      }
      else
      {
        int distance = Y - X;
        int count = (distance - distance % D) / D;
        return distance % D == 0 ? count : count + 1;
      }
    }

    //PermMissingElem
    public static int PermMissingElem(int[] A)
    {
      int result = 0;

      var sortedA = A.OrderBy(n => n).ToArray();
      for (int i = 0; i < sortedA.Count(); i++)
      {
        if (i + 1 != sortedA[i])
        {
          result = i + 1;
          break;
        }
      }
      if (result == 0)
      {
        result = sortedA.Count() + 1;
      }

      return result;
    }

    
  }
}
