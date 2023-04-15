// Input: A graph G and a vertex v of G
// Output: All vertices reachable from v //labeled as discovered
procedure DFS(G,v) {
  label v as "discovered"
  for all vertex w in G.adjacentVertices(v) {
    if (vertex w is not labeled as "discovered") {
      DFS(G, w)
     }
   }
}