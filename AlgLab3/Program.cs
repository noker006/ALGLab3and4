using System;

namespace AlgLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ex ="";
            while (ex != "0") {
                Console.WriteLine("\n ex2\n ex3\n ex4");
                ex = Console.ReadLine();
                switch (ex)
                {
                    case "ex2":
                        {
                            Console.Clear();
                            ExecutionTask.Ex2Main();
                            break;
                        }
                    case "ex3":
                        {
                            Console.Clear();
                            ExecutionTask.Ex3Main();
                            break;
                        }
                    case "ex4":
                        {
                            Console.Clear();
                            ExecutionTask.Ex4Main();
                            break;
                        }
                    default:
                        Console.Clear();
                        Console.WriteLine("\nEnter ex2 or ex3 or ex4");
                        break;
                }
            }
        }
        

    }
}
