using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrefixSums
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] A = new int[] { 0, 1, 0, 1, 1 };
      //List<int> A = new List<int>();
      //Random r = new Random();
      //for (Int64 i = 0; i < 1000000000; i++)
      //{
      //  A.Add(r.Next(0, 2));
      //}
      int answer = PassingCars(A);
    }


    public static int PassingCars(int[] A)
    {
      int answer = 0;
      int increment = 0;

      for (int i = 0; i < A.Length; i++)
      {
        if (A[i] == 0)
        {
          increment++;
        }
        else if (A[i] == 1)
        {
          answer += increment;
          if (answer > 1000000000)
            return -1;
        }
      }
      return answer;
    }
  }
}
