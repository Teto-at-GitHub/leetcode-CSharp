namespace BinaryTree.Main.MaximumDepthBinaryTree
{
   public class Solution
   {
      public int MaxDepth(TreeNode root)
      {
         if (root is null)
            return 0;
         
         return 1 + Math.Max(MaxDepth(root.left),MaxDepth(root.right));
      }
   }

}