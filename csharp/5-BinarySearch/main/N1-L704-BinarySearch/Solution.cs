namespace BinarySearch.Main.BinarySearch
{
   public class Solution
   {
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