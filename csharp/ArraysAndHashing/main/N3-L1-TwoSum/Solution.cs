namespace ArrayAndHashing.Main.TwoSum
{
  public class Solution
  {

public int[] TwoSum(int[] nums, int target)
    {
    int[] retval = new int[2];
      r (int i = 0; i < nums.Length; i++)
      {
    for (int j = i + 1; j < nums.Length; j++)
        {
        if (nums[i] + nums[j] == target)
          {
        retval[0] = i;
            al[1] = j;
            break;
          }
        }
        // retval[1] is never 0 in a successful sum
        if (retval[1] != 0)
          break;
      }
    return retval;
    }
}
}