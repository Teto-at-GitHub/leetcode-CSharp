namespace OneDimDynamicProgramming.Main.HouseRobber
{
   public class Solution
   {
      public int Rob(int[] moneyArray)
      {
         int oddSum = 0;
         int evenSum = 0;

         foreach (var moneyInHouse in moneyArray)
         {
            int temp = Math.Max(moneyInHouse + oddSum, evenSum);
            oddSum = evenSum;
            evenSum = temp;
         }

         return evenSum;
      }
   }
}
