using System;
using Algo.Dijkstra;
using Algo.BFS;
using Algo.DFS;

namespace Algo {
    public class Program
    {
        static void Main()
        {
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

            int[] goalState = new int[]
            {
                1, 2, 3,
                8, 0, 4,
                7, 6, 5
            };

            int[] goalStateFile = new int[]
            {
                7, 2, 4,
                5, 0, 6,
                8, 3, 1
            };

            int[] example = new int[]
            {
                8, 6, 4,
                2, 1, 3,
                5, 7, 0
            };

            DijkstraAlgorithm dijkstra = new DijkstraAlgorithm();
            BFSAlgorithm bfs = new BFSAlgorithm();
            DFSAlgorithm DFS = new DFSAlgorithm();

            int totalDijkstra = dijkstra.Dijkstra(sample2, goalState);
            int totalBFS = bfs.BFS(example, goalStateFile);
            int totalDFS = DFS.DFS_Calc(example, goalState);

            Console.WriteLine($"Result for Dijkstra: {totalDijkstra}");
            Console.WriteLine($"Result for BFS: {totalBFS}");
            Console.WriteLine($"Result for DFS: {totalDFS}");
        }
    }
}