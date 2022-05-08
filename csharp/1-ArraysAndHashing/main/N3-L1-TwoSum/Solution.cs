namespace ArrayAndHashing.Main.TwoSum
{
   public class Solution
   {

      // time complexity : O(n^2)
      // space complexity : O(2n)
      // where n = nums.Length
      public int[] TwoSumN2(int[] nums, int target)
      {
         int[] retval = new int[2];
         for (int i = 0; i < nums.Length; i++)
         {
            for (int j = i + 1; j < nums.Length; j++)
            {
               if (nums[i] + nums[j] == target)
               {
                  retval[0] = i;
                  retval[1] = j;
                  break;
               }
            }
            // retval[1] is never 0 in a successful sum
            if (retval[1] != 0)
               break;
         }
         return retval;
      }

      // time complexity : O(n) = only one for loop +
      //      in a Dictionary retrieval time by key is O(1)
      // space complexity : O(n) = the size of the dictionary
      public int[] TwoSum(int[] nums, int target)
      {
         int[] retval = new int[2];
         Dictionary<int, int> map = new();
         for (int i = 0; i < nums.Length; i++)
         {
            int current_elem = nums[i];
            int diff = target - current_elem;
            if (map.ContainsKey(diff))
            {
               retval[0] = map[diff];
               retval[1] = i;
               break;
            }
            // you may have repeated elements in nums, see test case 4
            if (!map.ContainsKey(current_elem))
               map.Add(current_elem, i);
         }
         return retval;
      }

   }

}