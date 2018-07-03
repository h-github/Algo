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
      //int[] A = new int[] { 0, 1, 0, 1, 1 };
      //int answer = PassingCars(A);

      //int answer = CountDiv(11, 14, 2);


    }

    //public static int CountDiv(int A, int B, int K)
    //{
    //  int answer = 0;

    //  if (A == B && A % K == 0)
    //    return 1;

    //  if (A == B && A % K != 0)
    //    return 0;

    //  //answer += (((B - A) - ((B - A) % K)) / K);
    //  answer += ((B - (B % K)) - (A - (A % K))) / K;

    //  if (A % K == 0)
    //  {
    //    answer++;
    //  }

    //  return answer;
    //}

    //public static int PassingCars(int[] A)
    //{
    //  int answer = 0;
    //  int increment = 0;

    //  for (int i = 0; i < A.Length; i++)
    //  {
    //    if (A[i] == 0)
    //    {
    //      increment++;
    //    }
    //    else if (A[i] == 1)
    //    {
    //      answer += increment;
    //      if (answer > 1000000000)
    //        return -1;
    //    }
    //  }
    //  return answer;
    //}
  }
}
