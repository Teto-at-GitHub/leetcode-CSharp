namespace OneDimDynamicProgramming.Main.HouseRobber
{
   // tc : O(n), where n = nums.Length
   // sc : O(1) <-- need only two vars : s1, s2
   public class Solution
   {
      public int Rob(int[] nums)
      {
         int s2 = 0;
         int s1 = 0;

         foreach (var x in nums)
         {
            int s3 = Math.Max(s2, x + s1);
            s1 = s2;
            s2 = s3;
         }

         return s2;
      }
   }
}
