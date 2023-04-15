bintree-bfs(bintree, elt, i)
  if (i == LENGTH)
    return false

  else if (bintree[i] == elt)
    return true

  else 
    return bintree-bfs(bintree, elt, i+1)