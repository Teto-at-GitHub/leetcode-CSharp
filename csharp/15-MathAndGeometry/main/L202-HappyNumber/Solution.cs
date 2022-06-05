// based on https://www.youtube.com/watch?v=ljz85bxOYJ0
// time complexity : 
// space complexity : O(n) <== using Hashset
public class Solution
{

   public bool IsHappy(int n)
   {
      HashSet<int> visited = new();

      while (!visited.Contains(n))
      {
         visited.Add(n);
         n = squareAndAddDigits(n);

         if (n == 1)
            return true;
      }

      return false;
   }

   private int squareAndAddDigits(int n)
   {
      int retval = 0;

      while (n != 0)
      {
         int digit = n % 10;
         retval += (int)Math.Pow(digit, 2);
         n = n / 10;
      }

      return retval;
   }
}