namespace OneDimDynamicProgramming.Main.ClimbingStairs
{
   //FIXME
   // does not work with 3
   public class Solution
   {
      // tc : O(n) <== looping over n
      // sc : O(1) <== only two variables needed, regardless of n
      public int ClimbStairs(int n)
      {
         int pt1 = 1;
         int pt2 = 1;

         for (int i = 1; i < n; i++)
         {
            int temp = pt1;
            pt1 = pt1 + pt2;
            pt2 = temp;
         }

         return pt1;
      }
   }
}