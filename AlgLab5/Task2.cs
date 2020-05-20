using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgLab5
{
    class Task2
    {
        //рекурсивно пробегаемся по графу через nextPoint и идем по граням пока не замкнемся или фолс
        public static bool isCyclicUtil(int nextPoint, bool[] visited, int parent, int startPoint, List<List<int>> listAdjacency)
        {
            visited[nextPoint] = true;

            foreach (int i in listAdjacency[nextPoint])
            {
                if (!visited[i])
                {
                    if (isCyclicUtil(i, visited, nextPoint, startPoint, listAdjacency))
                    {
                        return true;
                    }
                }
                else if (i != parent && i == startPoint)
                {
                    return true;
                }
            }
            return false;
        }


        public static bool checkCycle(List<List<int>> listAdjacency, int startPoint, int finishPoint)
        {
            bool[] visited = new bool[listAdjacency.Count()];

            if (!(listAdjacency[startPoint].Contains(finishPoint) && listAdjacency[finishPoint].Contains(startPoint)))
            {
                return false;
            }
            for (int i = 0; i < listAdjacency.Count(); i++)
            {
                visited[i] = false;
            }
            visited[startPoint] = true;
            if (isCyclicUtil(finishPoint, visited, startPoint, startPoint, listAdjacency))
            {
                return true;
            }
            return false;
        }
    }
}
