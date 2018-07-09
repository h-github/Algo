using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chees
{
  class Program
  {
    static void Main(string[] args)
    {

      //Given a infinite square and a position consisting of x & y coordinate.Knight is at (0, 0) you have to find minimum number of hopes to reach to destination.

      int baseSpotX = 1;
      int baseSpotY = 1;
      int destinationSpotX = 2;
      int destinationSpotY = 9;

      int minHopes = GetMinKnightHopes(baseSpotX, baseSpotY, destinationSpotX, destinationSpotY);



    }

    private static int GetMinKnightHopes(int baseX, int baseY, int X, int Y)
    {
      string basePositionKey = $"{baseX},{baseY}";
      string finalPositionKey = $"{X},{Y}";
      if (X == 0 && Y == 0)
        return 0;

      List<int[]> operations = new List<int[]>
      {
        new int[] { -1, -2 },
        new int[] { -2, -1 },
        new int[] { -2, 1 },
        new int[] { 1, -2 },
        new int[] { -1, 2 },
        new int[] { 2, -1 },
        new int[] { 1, 2 },
        new int[] { 2, 1 }
      };

      Dictionary<string, int> coordinateHopesNumber = new Dictionary<string, int>(); // key is coordinate "x,y" & value is the hopes number

      int coordX = baseX;
      int coordY = baseY;
      int counter = 0;
      coordinateHopesNumber.Add(basePositionKey, counter);

      while (!coordinateHopesNumber.Keys.Contains(finalPositionKey))
      {
        List<string> keys = coordinateHopesNumber.Where(i => i.Value == counter).Select(k=>k.Key).ToList();
        counter++;
        foreach (var item in keys)
        {
          foreach (var oper in operations)
          {
            int testX = int.Parse(item.Split(',')[0]) + oper[0]; //x
            int testY = int.Parse(item.Split(',')[1]) + oper[1]; //y
            string newPositionKey = $"{testX},{testY}";
            if ((testX >= baseX && testY >= baseY) && !coordinateHopesNumber.Keys.Contains(newPositionKey))
            {
              coordinateHopesNumber.Add(newPositionKey, counter);
              if (newPositionKey == finalPositionKey)
              {
                return counter;
              }
            }
          }
        }
      }

      return coordinateHopesNumber.Where(i => i.Key == finalPositionKey).First().Value;
    }
  }
}
