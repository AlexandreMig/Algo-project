// Input: A graph G and a vertex v of G
// Output: All vertices reachable from v //labeled as discovered
using System;
/*
int AddWeight(int v, int weight)
{
    weight = weight + v;
    return weight;
}

static void DFS(int[] G, int v, bool[] visited, int next_i, int weight)
{
    visited[next_i] = true;
    Console.Write("<" + G[next_i] + ">");
    for( int i = 0; i < v; i ++)
    {
        if(i == next_i)
        {
            continue;
        }
        if( i == 3)
        {
            Console.WriteLine();
        }
        if(!visited[i] && G[next_i, i] == i)
        {
            DFS(G, v, visited, i);
        }

    }
    Console.Write("cost of procedure: " + weight);    
}*/