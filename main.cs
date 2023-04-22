class AlgoProject
{
    static DijkstraAlgorithm dijkstra = new DijkstraAlgorithm();
    static void Main(string[] args)
    {
        // Your application logic goes here

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

        Console.WriteLine($"Result: {total}"); // Print the result to the console

        // Wait for user input before exiting
        Console.ReadLine();
    }
}


internal class GraphList
{
    private class Edge
    {
        public int Node_Adjacent; //adjacent node initialization
        public Edge next;
    }

    private class Graph
    {
        public bool visited; //boolean call for visited
        public Edge head;
        public int weight;
    }
    Graph[] graphlinks; //array for input 
    int graphSize = 9; //size of graph should be 9
    public GraphList() { }
}