// Input: A graph G and a vertex v of G
// Output: All vertices reachable from v //labeled as discovered
public void DFS()
{
    for (int v = 1; v < graphsize; v++)
    {
        if (!graphlinks[v].visited)
        {
            DFS_checks(v);
        }
    }
    EdgeNode current = null;
    EdgeNode adjacent = null;
    Console.WriteLine("DFS output:");
    for (int i = 1; i <= graphSize; i++)
    {
        current = graphlinks[i].head;
        if (current.next != null)
        {
            adjacent = current.next;
        }
        while (current != null && adjacent != null)
        {
            Console.Write(current.graphlinks);
            while (adjacent != null)
            {
                string node_printer = "<" + adjacent.graphlinks + ">";
                Console.Write(line);
                adjacent = graphlinks.next;
                if (i = 3)
                {
                    Console.WriteLine();
                }
            }
        }
        Console.WriteLine(weight);
    }
}

private void DFS_Checks(int v)
{
    graphSize[v].visited = true;
    weight = v + weight;
    int w = vertex;
    Edge n = null;
    if (graphlinks[v].head.next != null)
    {
        n = graphlinks[v].head.next;
        w = n.Node_Adjacent;
    }
    if (!graphlinks[v].visited)
    {
        DFS_checks(w);
    }
}