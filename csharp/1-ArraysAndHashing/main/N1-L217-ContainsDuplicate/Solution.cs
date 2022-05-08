namespace ArrayAndHashing.Main.ContainsDuplicate
{
  public class Solution
  {
    public bool ContainsDuplicate(int[] nums)
    {
      HashSet<int> seenNums = new();
      foreach (var item in nums)
      {
        if (seenNums.Contains(item))
          return true;
        seenNums.Add(item); 
      }

      return false;
    }
  }
}
