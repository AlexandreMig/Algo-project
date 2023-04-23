
namespace Algo.Dijkstra
{
public partial class DijkstraAlgorithm
{
    PriorityQueue<Node, int> knownStates = new PriorityQueue<Node, int>();
    List<int[]> visited = new List<int[]>();

    public int Dijkstra(int[] start, int[] goal, Node node = null)
    {

        if (node != null && node.Cost == 40) { }
        if (node != null && start.SequenceEqual(goal))
        {
            return 1;
        }

        if (node == null)
            node = new Node(start, 0, 0, null);


        int i = 0;
        for (; node.State[i] != 0; i++) ;


        int[] newState;
        switch (i)
        {
            case 0: //1, 3
                newState = GenerateNextState(start, 1, 0);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[1], 1, node), node.Cost + node.State[1]);
                    visited.Add(newState);
                }

                newState = GenerateNextState(start, 3, 0);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[3], 3, node), node.Cost + node.State[3]);
                    visited.Add(newState);
                }
                break;

            case 1: //0, 2, 4                        

                newState = GenerateNextState(start, 0, 1);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[0], 0, node), node.Cost + node.State[0]);
                    visited.Add(newState);
                }

                newState = GenerateNextState(start, 2, 1);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[2], 2, node), node.Cost + node.State[2]);
                    visited.Add(newState);
                }

                newState = GenerateNextState(start, 4, 1);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[4], 4, node), node.Cost + node.State[4]);
                    visited.Add(newState);
                }
                break;

            case 2: //1, 5                           

                newState = GenerateNextState(start, 1, 2);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[1], 1, node), node.Cost + node.State[1]);
                    visited.Add(newState);
                }

                newState = GenerateNextState(start, 5, 2);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[5], 5, node), node.Cost + node.State[5]);
                    visited.Add(newState);
                }
                break;

            case 3: //0, 4                           

                newState = GenerateNextState(start, 0, 3);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[0], 0, node), node.Cost + node.State[0]);
                    visited.Add(newState);
                }


                newState = GenerateNextState(start, 4, 3);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[4], 4, node), node.Cost + node.State[4]);
                    visited.Add(newState);
                }
                break;

            case 4: //1, 3, 5, 7                     

                newState = GenerateNextState(start, 1, 4);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[1], 1, node), node.Cost + node.State[1]);
                    visited.Add(newState);
                }

                newState = GenerateNextState(start, 3, 4);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[3], 3, node), node.Cost + node.State[3]);
                    visited.Add(newState);
                }

                newState = GenerateNextState(start, 5, 4);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[5], 5, node), node.Cost + node.State[5]);
                    visited.Add(newState);
                }

                newState = GenerateNextState(start, 7, 4);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[7], 7, node), node.Cost + node.State[7]);
                    visited.Add(newState);
                }
                break;

            case 5: //2, 4                                     


                newState = GenerateNextState(start, 2, 5);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[2], 2, node), node.Cost + node.State[2]);
                    visited.Add(newState);
                }

                newState = GenerateNextState(start, 4, 5);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[4], 4, node), node.Cost + node.State[4]);
                    visited.Add(newState);
                }
                break;

            case 6: //3, 7                           

                newState = GenerateNextState(start, 3, 6);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[3], 3, node), node.Cost + node.State[3]);
                    visited.Add(newState);
                }

                newState = GenerateNextState(start, 7, 6);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[7], 7, node), node.Cost + node.State[7]);
                    visited.Add(newState);
                }
                break;

            case 7: //4, 6, 8                        

                newState = GenerateNextState(start, 4, 7);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    { }
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[4], 4, node), node.Cost + node.State[4]);
                    visited.Add(newState);
                }

                newState = GenerateNextState(start, 6, 7);
                if (!visited.Any(arr => arr.SequenceEqual(newState)))
                {
                    knownStates.Enqueue(new Node(newState, node.Cost + node.State[6], 6, node), node.Cost + node.State[6]);
                    visited.Add(newState);
                }

                newState = GenerateNextState(start, 8, 7);
                    if (!visited.Any(arr => arr.SequenceEqual(newState)))
                    {
                        knownStates.Enqueue(new Node(newState, node.Cost + node.State[8], 8, node), node.Cost + node.State[8]);
                        visited.Add(newState);
                    }
                    break;

            case 8: //5, 7                           

                newState = GenerateNextState(start, 5, 8);
                    if (!visited.Any(arr => arr.SequenceEqual(newState)))
                    {
                        knownStates.Enqueue(new Node(newState, node.Cost + node.State[5], 5, node), node.Cost + node.State[5]);
                        visited.Add(newState);
                    }

                    newState = GenerateNextState(start, 7, 8);
                    if (!visited.Any(arr => arr.SequenceEqual(newState)))
                    {
                        knownStates.Enqueue(new Node(newState, node.Cost + node.State[7], 7, node), node.Cost + node.State[7]);
                        visited.Add(newState);
                    }
                    break;
                }

                if (node.Parent == null)
            while (knownStates.Count > 0)
            {
                Node newNode = knownStates.Dequeue();
                if (Dijkstra(newNode.State, goal, newNode) == 1)
                {
                    string currentOrder = "";

                    for (int j = 0; j < newNode.State.Length; j++)
                    {
                        if (node.State[j] == 0)
                            currentOrder += "0" + " ";
                        else
                            currentOrder += newNode.State[j] + " ";

                        if (j == 2 || j == 5 || j == 8)
                            currentOrder += "\n";
                    }
                    Console.WriteLine($"{newNode.Cost}\n{currentOrder}\n");

                    return newNode.Cost;
                }
            }

        return 0;   //The desired state was not found
    }

    int[] GenerateNextState(int[] current, int start, int end)
    {
        int[] temp = (int[])current.Clone();
        temp[end] = temp[start];
        temp[start] = 0;
        return temp;
    }

    public class Node
    {
        public int[] State; // State of the puzzle
        public int Cost; // Cost to reach this state
        public int Move; // Move made to reach this state
        public Node Parent; // Parent node

        public Node(int[] state, int cost, int move, Node parent)
        {
            State = state;
            Cost = cost;
            Move = move;
            Parent = parent;
        }
    }
}
}