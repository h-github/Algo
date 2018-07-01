using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotation
{
  class Program
  {
    static void Main(string[] args)
    {

      //int[] A = new int[] { };
      //int K = 4;

      //var answer = Solution(A, K);

      //int[] B = new int[] { 0,0,0,0,0};

      //answer = Solution(B, K);

      //int[] C = new int[] { 32, 834, 9, 7, 6 };
      //K = 3;
      //var answer3 = Solution(C, K);
      //int[] D = new int[] { 3, 8 };
      //K = 0;
      //var answer4 = Solution(D, K);

      int[] A = new int[] { 9, 3, 9, 3, 9, 7, 9, 7, 7 };
      var answer = Solution2(A);

      int[] B = new int[] { 9 };
      answer = Solution2(B);

      int[] C = new int[] { 90000000, 3, 90000000, 3, 90000000, 7, 90000000, 7, 20 };
      answer = Solution2(C);
    }

    //OddOccurrencesInArray
    public static int Solution2(int[] A)
    {
      int unpaired = -1;
      if (A.Count() == 1)
      {
        unpaired = A[0];
      }
      else
      {
        var orderedA = A.OrderBy(n => n).ToArray();
        int previousInt = 0;
        for (int i = 0 ; i < orderedA.Count(); i++)
        {
          if(previousInt != orderedA[i])
          {
            if (i == orderedA.Count() - 1 || orderedA[i] != orderedA[i + 1])
            {
              unpaired = orderedA[i];
              break;
            }
            previousInt = orderedA[i];
          }
          else
          {
            previousInt = 0;
          }
        }
      }
      return unpaired;
    }

    //public static int[] Solution(int[] A, int K)
    //{
    //  if (A.Count() == 0 || K % A.Count() == 0 || A.Distinct().Count() == 1)
    //  {
    //    return A;
    //  }
    //  else
    //  {
    //    int count = A.Count();
    //    int[] result = new int[count];
    //    int remaining = K % A.Count();
    //    var firstSlice = A.Skip(A.Count() - remaining).Take(remaining).ToArray();
    //    var secondSlice = A.Take(A.Count() - remaining).ToArray();
    //    result = firstSlice.Concat(secondSlice).ToArray();
    //    return result;
    //  }
    //}

    

  }
}
