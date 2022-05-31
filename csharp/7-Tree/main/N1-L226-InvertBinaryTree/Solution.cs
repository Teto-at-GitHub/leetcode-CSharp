namespace BinaryTree.Main.InvertBinaryTree
{
   //   Definition for a binary tree node.
   public class TreeNode
   {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
      {
         this.val = val;
         this.left = left;
         this.right = right;
      }
   }

   // MAIN IDEA :
   // recursively visit each node and swap its children
   // Use Depth First Search (DFS)
   public class Solution
   {
      public TreeNode InvertTree(TreeNode root)
      {
         if (root == null)
         {
            return null;
         }
         else
         {
            var tmp = root.left;
            root.left = root.right;
            root.right = tmp;
         }

         this.InvertTree(root.left);
         this.InvertTree(root.right);

         return root;
      }
   }

}


