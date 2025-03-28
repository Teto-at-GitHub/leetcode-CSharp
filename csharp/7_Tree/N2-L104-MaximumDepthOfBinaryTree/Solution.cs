using System.Collections;

namespace BinaryTree.Main.MaximumDepthBinaryTree
{
    public class Solution
    {
        //Depth Search First
        public int MaxDepthDFS(TreeNode root)
        {
            if (root is null)
                return 0;

            return 1 + Math.Max(MaxDepthDFS(root.left), MaxDepthDFS(root.right));
        }

        // BFS
        public int MaxDepthBFS(TreeNode root)
        {
            if (root is null)
                return 0;

            var q = new Queue<TreeNode>();
            var treeLevel = 0;

            q.Enqueue(root);
            while (q.Any())
            {
                for (int i = 0; i < q.Count; i++)
                {
                    var node = q.Dequeue();
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }

                treeLevel++;
            }

            return treeLevel;
        }

        // Iterative DFS
        public int MaxDepthIterativeDFS(TreeNode root)
        {
            int treeLevel = 0;

            var s = new Stack<Tuple<TreeNode, int>>();
            s.Push(new(root, 1));

            while (s.Any())
            {
                var current = s.Pop();
                var node = current.Item1;
                int depth = current.Item2;

                if (node != null)
                {
                    treeLevel = Math.Max(treeLevel, depth);
                    s.Push(new Tuple<TreeNode, int>(node.left, depth + 1));
                    s.Push(new Tuple<TreeNode, int>(node.right, depth + 1));
                }
            }

            return treeLevel;
        }
    }
}