using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
  class Program
  {
    static void Main(string[] args)
    {
      int N = Convert.ToInt32(Console.ReadLine());

      int maxGap = 0;
      string binaryN = Convert.ToString(N, 2);
      List<char> arryBinarryN = binaryN.ToCharArray().ToList();
      int countOnes = arryBinarryN.FindAll(c => c == '1').Count();
      if (countOnes == arryBinarryN.Count() || countOnes == 1)
      {
        maxGap = 0;
      }
      else if (countOnes > 1)
      {
        int preIdx = 0;
        for(int i = 0; i < arryBinarryN.Count(); i++)
        {
          if (arryBinarryN[i] == '1')
          {
            maxGap = maxGap < i - preIdx - 1 ? i - preIdx - 1 : maxGap;
            preIdx = i;
          }
        }
      }


      Console.WriteLine(maxGap);
      Console.ReadLine();
    }
  }
}
