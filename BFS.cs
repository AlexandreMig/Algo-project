
namespace Algo.BFS
{
    public partial class BFSAlgorithm
    {
        Queue<Node> knownStates = new Queue<Node>();
        List<int[]> visited = new List<int[]>();

        public int BFS(int[] start, int[] goal, Node node = null)
        {
            if (!canSolve(start, 3, 3))
            {
                Console.WriteLine("The puzzle is not solvable.");
                return 0;
            }

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
                    EnqueueIfNotVisited(newState, node);

                    newState = GenerateNextState(start, 3, 0);
                    EnqueueIfNotVisited(newState, node);
                    break;

                case 1: //0, 2, 4
                    newState = GenerateNextState(start, 0, 1);
                    EnqueueIfNotVisited(newState, node);

                    newState = GenerateNextState(start, 2, 1);
                    EnqueueIfNotVisited(newState, node);

                    newState = GenerateNextState(start, 4, 1);
                    EnqueueIfNotVisited(newState, node);
                    break;

                case 2: //1, 5
                    newState = GenerateNextState(start, 1, 2);
                    EnqueueIfNotVisited(newState, node);

                    newState = GenerateNextState(start, 5, 2);
                    EnqueueIfNotVisited(newState, node);
                    break;

                case 3: //0, 4
                    newState = GenerateNextState(start, 0, 3);
                    EnqueueIfNotVisited(newState, node);

                    newState = GenerateNextState(start, 4, 3);
                    EnqueueIfNotVisited(newState, node);
                    
                    newState = GenerateNextState(start, 6, 3);
                    EnqueueIfNotVisited(newState, node);
                    break;

                case 4: //1, 3, 5, 7
                    newState = GenerateNextState(start, 1, 4);
                    EnqueueIfNotVisited(newState, node);

                    newState = GenerateNextState(start, 3, 4);
                    EnqueueIfNotVisited(newState, node);

                    newState = GenerateNextState(start, 5, 4);
                    EnqueueIfNotVisited(newState, node);

                    newState = GenerateNextState(start, 7, 4);
                    EnqueueIfNotVisited(newState, node);
                    break;

                case 5: //2, 4
                    newState = GenerateNextState(start, 2, 5);
                    EnqueueIfNotVisited(newState, node);

                    newState = GenerateNextState(start, 4, 5);
                    EnqueueIfNotVisited(newState, node);

                    newState = GenerateNextState(start, 8, 5);
                    EnqueueIfNotVisited(newState, node);
                    break;

                case 6: //3, 7
                    newState = GenerateNextState(start, 3, 6);
                    EnqueueIfNotVisited(newState, node);

                    newState = GenerateNextState(start, 7, 6);
                    EnqueueIfNotVisited(newState, node);
                    break;

                case 7: //4, 6, 8
                    newState = GenerateNextState(start, 4, 7);
                    EnqueueIfNotVisited(newState, node);

                    newState = GenerateNextState(start, 6, 7);
                    EnqueueIfNotVisited(newState, node);

                    newState = GenerateNextState(start, 8, 7);
                    EnqueueIfNotVisited(newState, node);
                    break;

                case 8: //5, 7
                    newState = GenerateNextState(start, 5, 8);
                    EnqueueIfNotVisited(newState, node);

                    newState = GenerateNextState(start, 7, 8);
                    EnqueueIfNotVisited(newState, node);
                    break;
            }

            if (node.Parent == null)
            {
                while (knownStates.Count > 0)
                {
                    Node newNode = knownStates.Dequeue();
                    if (BFS(newNode.State, goal, newNode) == 1)
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

                        return newNode.Cost;
                    }
                }
            }

            return 0;   // The desired state was not found
        }

        public bool canSolve(int[] p, int w, int h)
        {
            int inv = 0;
            int empt = 0;

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == 0)
                {
                    empt = i / w;
                    continue;
                }

                for (int j = i + 1; j < p.Length; j++)
                {
                    if (p[j] != 0 && p[i] > p[j])
                    {
                        inv++;
                    }
                }
            }

            if (h % 2 == 1)
            {
                return inv % 2 == 0;
            }
            else
            {
                return (inv + empt) % 2 != 0;
            }
        }

        void EnqueueIfNotVisited(int[] newState, Node node)
        {
            if (!visited.Any(arr => arr.SequenceEqual(newState)))
            {
                knownStates.Enqueue(new Node(newState, node.Cost + 1, 0, node));
                visited.Add(newState);
            }
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
