namespace BinaryTree.Main.InvertBinaryTree
{
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


