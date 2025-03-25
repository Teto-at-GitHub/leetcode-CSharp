namespace BinaryTree.Main.InvertBinaryTree
{
   // MAIN IDEA :
   // recursively visit each node and swap its children
   // Use Depth First Search (DFS)
   // Time Complexity: O(n), where n is the number of nodes in the binary tree. We are visiting each node once, hence the time complexity is linear.
   // Space Complexity: O(h), where h is the height of the binary tree
   public class Solution
   {
      public TreeNode InvertTree(TreeNode root)
      {
         if (root == null)
            return null;
         
         (root.left, root.right) = (root.right, root.left);

         InvertTree(root.left);
         InvertTree(root.right);

         return root;
      }
   }

}


