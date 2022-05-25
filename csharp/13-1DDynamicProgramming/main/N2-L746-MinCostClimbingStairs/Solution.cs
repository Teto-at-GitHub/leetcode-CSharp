namespace OneDimDynamicProgramming.Main.MinCostClimbingStairs
{
   // tc : O(n)
   // sc : O(1)
   public class Solution
   {
      public int MinCostClimbingStairs(int[] cost)
      {
         cost.Append(0);

         for (int i = cost.Length - 3; i >= 0; i--)
         {
            // original understandable code :
            // cost[i] = Math.Min(cost[i]+cost[i+1],cost[i] + cost[i + 2]);
            // optimization :
            cost[i] += Math.Min(cost[i + 1], cost[i + 2]);
         }

         // this is safe because of the constraint cost.lenght >= 2
         return Math.Min(cost[0],cost[1]);
      }
   }
}