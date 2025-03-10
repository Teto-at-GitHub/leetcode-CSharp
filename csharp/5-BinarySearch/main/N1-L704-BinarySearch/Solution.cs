namespace BinarySearch.Main.BinarySearch
{
   public class Solution
   {
      
      // - time complexity: O(log n) bc if you start with n values in the array
      // and then you don't find the target, in the next step you have n/2 possibilities to examine,
      // then n/4 and so on. So in the worst case scenario, before you reach 1,
      // you need to iterate as many times as you can divide n by 2, which is precisely log_2(n)  
      public int Search(int[] nums, int target)
      {
         int leftPt = 0;
         int rightPt = nums.Length - 1;

         while (leftPt <= rightPt)
         {
            // use this definition instead of 
            // (rightPt + leftPt) / 2
            // to avoid overflow
            int indexAtHalf = leftPt + ((rightPt - leftPt) / 2);

            if (target > nums[indexAtHalf])
               leftPt = indexAtHalf + 1;
            else if (target < nums[indexAtHalf])
               rightPt = indexAtHalf - 1;
            else
               return indexAtHalf;
         }

         return -1;
      }
   }
}