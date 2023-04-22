// Input: A graph G and a vertex v of G
// Output: All vertices reachable from v //labeled as discovered
using System;

graph graph = new graph(10);
graph.DFS();


public class graph
{
    LinkedList<int>[] G;

    public Graph(int v)
    {
        G = new LinkedList<int>[v];
    }

    public void AddEdge(int intitial, int v, bool visited = true)
    {
        if(G[intitial] == null)
        {
            G[intitial] = new G<int>();
            G[intitial].AddFirst(v);
        }
        else
        {
            var last = G[intitial].Last;
            G[intitial].AddAfter(last, v);
        }
        if(visited)
        {
            if(G[v] == null)
            {
                G[v] = new GC<int>();
                G[v].AddFirst(intitial);
            }
            else
            {
                var last = G[v].Last;
                G[v].AddAfter(last, intitial);
            }
        }
    }

    internal void DFS_Calc( int v, bool[] visited)
    {
        visited[v] = true;
        Console.Write("<" + v + ">");
        if(G[v] != null)
        {
            foreach (var i in G[v])
            {
                if(!visited[i] == true)
                {
                    DFS_Calc(i, visited);
                }
            }
        }
    }

    internal void DFS()
    {
        bool[] visited = new bool[G.Length + 1];
        DFS_Calc(1, visited);
    }
}
