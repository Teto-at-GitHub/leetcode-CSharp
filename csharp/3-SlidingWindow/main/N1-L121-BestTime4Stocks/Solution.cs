namespace SlidingWindow.Main.BestTime4Stocks
{
   public class Solution
   {
      // time complexity : O(n), n = prices.length, bc only go through the array once
      // space complexity : O(1), because you are using pointers
      public int MaxProfit(int[] prices)
      {
         int buyDay = 0; // left pointer
         int sellDay = 1; // right pointer
         int maxProfit = 0;

         while (sellDay < prices.Length)
         {
            // check if current transaction can be profitable
            if (prices[buyDay] < prices[sellDay])
            {
               // calculate revenue
               int currentProfit = prices[sellDay] - prices[buyDay];
               // update max possible profit if needed be
               maxProfit = Math.Max(maxProfit, currentProfit);
            }
            else
               buyDay = sellDay;

            sellDay++;
         }

         return maxProfit;
      }
   }
}