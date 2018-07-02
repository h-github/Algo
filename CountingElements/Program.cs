using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingElements
{
  class Program
  {
    static void Main(string[] args)
    {
      //int[] A = new int[] { 9, 5, 7, 3, 2, 7, 3, 1, 10, 8 };
      //int[] B = new int[] { 4, 1, 3 };
      //int[] C = new int[] { 2, 1 };
      //int isPerm = PermCheck(A);
      //isPerm = PermCheck(B);
      //isPerm = PermCheck(C);
      //int[] A = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };
      //int answer = FrogRiver(5, A);
      // answer = FrogRiver(3, new int[] { 1, 3, 1, 3, 2, 1, 3 });
      // answer = FrogRiver(5, new int[] { 3 });
      //int[] A = new int[] { 1, 3, 6, 4, 1, 2 };
      //int answer = MissingInteger(A);
      //A = new int[] { 1, 2, 3 };
      //answer = MissingInteger(A);
      //A = new int[] { -1, -3 };
      //answer = MissingInteger(A);
      int[] A = new int[] { 3, 4, 4, 6, 1, 4, 4 };
      var answer = MaxCounters(5, A);

    }


    public static int[] MaxCounters(int N, int[] A)
    {
      int[] answer = new int[N];
      Dictionary<int, int> maxes = new Dictionary<int, int>();

      for(int i = 0; i < A.Length; i++)
      {
        if(A[i] > N)
        {
          maxes.Add(i, A[i]);
        }
      }

      for(int i = 0; i< N; i++)
      {

      }

      return answer;
    }

    //public static int[] MaxCounters(int N, int[] A)
    //{
    //  int[] answer = new int[N];
    //  int max = 0;
    //  foreach (int elem in A)
    //  {
    //    if (elem <= N)
    //    {
    //      answer[elem - 1]++;
    //      max = answer[elem - 1] > max ? answer[elem - 1] : max;
    //    }
    //    else
    //    {
    //      for (int i = 0 ; i < answer.Length ; i++)
    //      {
    //        answer[i] = max;
    //      }
    //    }
    //  }

    //  return answer;
    //}

    //public static int[] MaxCounters(int N, int[] A)
    //{
    //  int[] answer = new int[N];
    //  int max = 0;
    //  foreach (int elem in A)
    //  {
    //    if (elem <= N)
    //    {
    //      answer[elem - 1]++;
    //      max = answer[elem - 1] > max ? answer[elem - 1] : max;
    //    }
    //    else
    //    {
    //      answer = Enumerable.Repeat(max, N).ToArray();
    //    }
    //  }

    //  return answer;
    //}

    //public static int MissingInteger(int[] A)
    //{
    //  int answer = -1;
    //  var sortedA = A.Distinct().OrderBy(n => n).Where(n => n > 0).ToArray();
    //  if (sortedA.Length > 0)
    //  {
    //    for (int i = 0; i < sortedA.Length; i++)
    //    {
    //      if (sortedA[i] != i + 1)
    //      {
    //        answer = i + 1;
    //        break;
    //      }
    //    }
    //    if (answer == -1)
    //    {
    //      answer = sortedA.Max() + 1;
    //    }
    //  }
    //  else
    //  {
    //    return 1;
    //  }

    //  return answer;
    //}

    //public static int FrogRiver(int X, int[] A)
    //{
    //  int earliestTime = -1;
    //  var sortA = A.Where(n => n <= X).Distinct();
    //  if (sortA.Count() != X)
    //  {
    //    return -1;
    //  }
    //  else
    //  {
    //    Dictionary<int, int[]> positions = new Dictionary<int, int[]>();
    //    for (int i = 0; i < X; i++)
    //    {
    //      positions[i] = new int[] { 0, 0 };
    //    }

    //    for (int i = 0; i < A.Length; i++)
    //    {
    //      if (positions[A[i] - 1][1] != A[i])
    //      {
    //        positions[A[i] - 1] = new int[] { i, A[i] };
    //      }
    //    }
    //    earliestTime = positions.Select(p => p.Value[0]).Max();
    //  }
    //  return earliestTime;

    //}

    //public static int FrogRiverOne(int X, int[] A)
    //{
    //  int earliestTime = -1;
    //  var sortA = A.Where(n => n <= X).Distinct();
    //  if (sortA.Count() != X)
    //  {
    //    return -1;
    //  }
    //  else
    //  {
    //    int[] positions = new int[X];

    //    for (int i = 0; i < A.Length; i++)
    //    {
    //      positions[A[i] - 1] = A[i];
    //      if (!positions.Contains(0))
    //      {
    //        earliestTime = i;
    //        break;
    //      }
    //    }
    //    return earliestTime;
    //  }
    //}


    //public static int PermCheck(int[] A)
    //{
    //  int initialLength = A.Length;
    //  int[] sortedA = A.OrderBy(n => n).Distinct().ToArray();
    //  return (initialLength == sortedA.Length && sortedA[sortedA.Length - 1] == initialLength) ? 1 : 0;
    //}
  }
}
