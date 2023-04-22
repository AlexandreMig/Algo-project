using System;

int main()
{
        // Call the Dijkstra method
        int vertex = 0; // Set the value for vertex
        int total = 0; // Set the value for total
        //int result = dijkstra.Dijkstra(startState, goalState); // Call the Dijkstra method

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

        total = dijkstra.Dijkstra(sample2, goalState);
        weight = graph.DFS(sample2);

        Console.WriteLine($"Result: {total}"); // Print the result to the console

        // Wait for user input before exiting
        Console.ReadLine();
}

