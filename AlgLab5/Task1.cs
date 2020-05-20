using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgLab5
{
    class Task1
    {
        public static List<int> doubleDegrees(List<List<int>> listAdjacency)
        {
            List<int> requiredDoubleDegrees = new List<int>();
            int SumDegres = 0;
            for (int i = 0; i < listAdjacency.Count(); i++)
            {
                for (int j = 0; j < listAdjacency[i].Count(); j++)
                {
                    SumDegres += listAdjacency[listAdjacency[i][j]].Count();
                }
                requiredDoubleDegrees.Add(SumDegres);
                SumDegres = 0;
            }
            return requiredDoubleDegrees;
        }
    }
}
