/*
- In your own words, define BST balance factor.
=> BST balance factor is that (right subtree height) - (left subtree height)

- In your own words, describe the rules of 3 order B-tree.
=> 1. Every node contains at most 3 children.
   2. A non-leaf node has 2 children and 1 key or has 3 children and 2 keys.
   3. If is not the leaf node, the root node has at least two chilren and 1 key.
   4. Every non-leaf node has at least 2 children.
   5. All leaf nodes should be in same level.

- Insert the numbers 10 12 8 6 5 into an AVL tree
    - Draw the resulting tree before rebalancing
    =>  10
      8    12
     6 
    5

    - Draw the tree after balancing
    =>  10
      6    12
    5   8 
    
    - What rotation was performed in rebalancing the tree?
    => LL Imbalance - single right rotation (variation)
*/