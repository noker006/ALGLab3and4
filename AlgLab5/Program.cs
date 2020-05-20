using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> listAdjacency = HelpModel.createGraph();
            int selectedNum = 1;
            while (selectedNum != 0)
            {
                Console.WriteLine("task1.double degree of each vertex(write 1)\n" +"task2.Check Cycle in the graph(write 2)\n" +"task3.Check is Graph bipartite(write 3)\n");
                selectedNum = Convert.ToInt32(Console.ReadLine());
                switch (selectedNum)
                {
                    case 1:
                        {
                            List<int> doubleDegrees = Task1.doubleDegrees(listAdjacency);
                            for (int i = 0; i < doubleDegrees.Count(); i++)
                            {
                                Console.Write("\n"+doubleDegrees[i] + " ");
                            }
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Enter the edge through ' ': ");
                            string originString = Console.ReadLine();
                            string[] edges = originString.Split(' ');
                            int start = Convert.ToInt32(edges[0]);
                            int stop = Convert.ToInt32(edges[1]);
                            bool existedCycle = Task2.checkCycle(listAdjacency, start, stop);
                            if (existedCycle)
                            {
                                Console.WriteLine("Graph with cycle");
                            }
                            else
                            {
                                Console.WriteLine("No cycle");
                            }
                        }
                        break;

                    case 3:
                        {
                            bool isThereBipartite = Task3.CheckBipartite(listAdjacency);
                            if (isThereBipartite)
                            {
                                Console.WriteLine("Graph biparite");
                            }
                            else
                            {
                                Console.WriteLine("Graph not bipartite");
                            }
                        }
                        break;
                }
            }
        }
    }
}
