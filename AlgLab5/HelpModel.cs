using System;
using System.Collections.Generic;
using System.Text;

namespace AlgLab5
{
    class HelpModel
    {
        public static List<List<int>> createGraph()
        {
            string originalString = "";
            string[] splitedString;

            List<List<int>> listAdjacency = new List<List<int>>();

            Console.WriteLine("Enter num Vertex: ");
            int numVertex = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numVertex; i++)
            {
                Console.Write("Enter vertex adjacent(through ' ') " + i);
                originalString = Console.ReadLine();
                splitedString = originalString.Split(' ',',');
                listAdjacency.Add(new List<int>());
                for (int j = 0; j < splitedString.Length; j++)
                {
                    listAdjacency[i].Add(Convert.ToInt32(splitedString[j]));
                }
            }
            return listAdjacency;
        }
    }
}
