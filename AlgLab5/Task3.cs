using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgLab5
{
    class Task3
    {
        public static bool CheckBipartite(List<List<int>> listAdjacency)
        {
            int[] visited = new int[listAdjacency.Count()];

            for (int i = 0; i < visited.Count(); i++)
            {
                visited[i] = -1;
            }

            bool adjacentIsZero = false;

            for (int i = 0; i < listAdjacency.Count(); i++)
            {
                if (visited[i] == -1)
                {
                    if (!CheckPoint(i, visited, adjacentIsZero, listAdjacency))
                    {
                        return false;
                    }
                    if (visited[listAdjacency[i][0]] == 0 || visited[listAdjacency[i][0]] == -1)
                    {
                        adjacentIsZero = true;
                    }
                    else
                    {
                        adjacentIsZero = false;
                    }
                }
            }
            return true;
        }

        //рекурсивно идем по точкам(метод покраски)(меняя 0 1 0 1...  если совпали 1 1 или 0 0 то это уже не двудольный граф)
        public static bool CheckPoint(int v, int[] visited, bool adjacentIsZero, List<List<int>> listAdjacency)
        {
            if (!adjacentIsZero)
            {
                visited[v] = 1;
            }
            else
            {
                visited[v] = 0;
            }

            for (int i = 0; i < listAdjacency[v].Count; i++)
            {
                if (visited[listAdjacency[v][i]] == -1)
                {
                    CheckPoint(listAdjacency[v][i], visited, Convert.ToBoolean(visited[v]), listAdjacency);
                }
                else if (visited[v] == visited[listAdjacency[v][i]])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
