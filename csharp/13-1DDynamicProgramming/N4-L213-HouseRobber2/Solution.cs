using System.Linq;

namespace OneDimDynamicProgramming.Main.HouseRobber2
{
   public class Solution
   {
      public int Rob(int[] nums)
      {
         if (nums.Length == 1)
            return nums[0];

         return Math.Max(rob1(nums.Skip(1).ToArray()), rob1(nums.Take(nums.Length - 1).ToArray()));
      }

      private int rob1(int[] nums)
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