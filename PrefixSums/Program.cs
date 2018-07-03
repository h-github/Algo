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

      int[] P = new int[] { 2, 5, 0 };
      int[] Q = new int[] { 4, 5, 6 };
      string S = "CAGCCTA";

      var answer = GenomicRangeQuery(S, P, Q);
    }

    public static int[] GenomicRangeQuery(string S, int[] P, int[] Q)
    {
      int[] minimals = new int[P.Length];
      int[] impacts = new int[S.Length];

      for (int i = 0; i < S.Length; i++)
      {
        int impact = 0;

        switch (S[i])
        {
          case 'A':
            impact = 1;
            break;
          case 'C':
            impact = 2;
            break;
          case 'G':
            impact = 3;
            break;
          case 'T':
            impact = 4;
            break;
        }

        impacts[i] = impact;
      }

      if(impacts.Distinct().Count() == 1)
      {
        int elem = impacts.Distinct().First();
        return Enumerable.Repeat(elem, P.Length).ToArray();
      }

      for (int i = 0; i < P.Length; i++)
      {
        int min = P[i] <= Q[i] ? P[i] : Q[i];
        int max = P[i] >= Q[i] ? P[i] : Q[i];
        minimals[i] = impacts.Skip(min).Take(max - min + 1).Min();
      }

      return minimals;

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
