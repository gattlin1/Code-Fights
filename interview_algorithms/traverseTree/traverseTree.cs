//
// Definition for binary tree:
// class Tree<T> {
//   public T value { get; set; }
//   public Tree<T> left { get; set; }
//   public Tree<T> right { get; set; }
// }
int[] traverseTree(Tree<int> t) {
    List<int> tree_values = new List<int>();
    Queue<Tree<int>> tree_queue = new Queue<Tree<int>>();

    if(t != null)
    {
        tree_queue.Enqueue(t);
    }

    while(tree_queue.Count != 0)
    {
        Tree<int> node = tree_queue.Dequeue();
        tree_values.Add(node.value);

        if(node.left != null)
        {
            tree_queue.Enqueue(node.left);
        }

        if(node.right != null)
        {
            tree_queue.Enqueue(node.right);
        }
    }
    return tree_values.ToArray();
}
