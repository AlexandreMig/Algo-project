using System;
using Algo.Dijkstra;
using Algo.BFS;
using Algo.DFS;


namespace Algo {
    public class Program
    {
        static void Main()
        {
            //Ensure the user input file exists
            if (!File.Exists(@"UserInput.txt"))
                File.WriteAllText(@"UserInput.txt", "2 3 4\n8 0 2\n7 6 5");

            //Read file information
            string[] fileInformation = File.ReadAllText(@"UserInput.txt").Replace("\r", "").Replace("\n", " ").Split(' ');

            string currentOrder = "";
            for (int j = 0; j < fileInformation.Length; j++)
            {
                currentOrder += fileInformation[j] + " ";

                if (j == 2 || j == 5 || j == 8)
                    currentOrder += "\n";
            }
            Console.WriteLine($"Starting State\n{currentOrder}\n");

            int[] goalState = new int[]
            {
                1, 2, 3,
                8, 0, 4,
                7, 6, 5
            };

            int[] startState = new int[fileInformation.Length];

            for (int i = 0; i < fileInformation.Length; i++)
            {
                startState[i] = Int16.Parse(fileInformation[i]);
            }


            #region Testing Files
            int[] custom = new int[]
            {
                4, 1, 3,
                5, 8, 2,
                0, 6, 7
            };

            int[] sample1 = new int[]
            {
                1, 3, 4,
                8, 0, 2,
                7, 6, 5
            };

            int[] sample2 = new int[]
            {
                1, 3, 4,
                8, 0, 6,
                7, 5, 2
            };

            int[] example = new int[]
            {
                8, 6, 4,
                2, 1, 3,
                5, 7, 0
            };
            #endregion

            DijkstraAlgorithm dijkstra = new DijkstraAlgorithm();
            BFSAlgorithm bfs = new BFSAlgorithm();
            DFSAlgorithm DFS = new DFSAlgorithm();

            int totalDijkstra = dijkstra.Dijkstra(startState, goalState);
            int totalBFS = bfs.BFS(startState, goalState);
            int totalDFS = DFS.DFS_Calc(startState, goalState);

            Console.WriteLine($"Result for Dijkstra: {totalDijkstra}");
            Console.WriteLine($"Result for BFS: {totalBFS}");
            Console.WriteLine($"Result for DFS: {totalDFS}");

            Console.ReadLine();
        }
    }
}