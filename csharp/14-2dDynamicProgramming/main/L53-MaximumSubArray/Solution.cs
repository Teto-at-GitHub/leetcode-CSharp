namespace TwoDimDynamicProgrammin.Main.MaximumSubarray
{
   // TC : O(n) <== only one loop over the array
   // SC : O(1) <== using only two variables
   public class Solution
   {
      public int MaxSubArray(int[] nums)
      {
         if (nums.Length == 1)
            return nums[0];

         int currentSum = 0;
         int MaximumSubarray = Int32.MinValue;

         foreach (int number in nums)
         {
            if (currentSum < 0)
               currentSum = 0;
            currentSum += number;
            MaximumSubarray = Math.Max(MaximumSubarray,currentSum);
         }

         return MaximumSubarray;
      }
   }
}