namespace OneDimDynamicProgramming.Main.HouseRobber
{
   public class Solution
   {
      public int Rob(int[] nums)
      {
         int evenSum = 0;
         int oddSum = 0;

         int i = 0;
         while (i < nums.Length)
         {
            evenSum += nums[i];
            i++;
            if (i == nums.Length)
               break;
            oddSum += nums[i];
            i++;
         }

         return Math.Max(evenSum, oddSum);
      }
   }
}
