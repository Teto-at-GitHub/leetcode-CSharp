namespace _11_BackTracking.Permutations;

public class Solution
{
    /// Time commplexity:
    /// O(n! * n^2)
    /// n! for every time you call permute
    /// n^2 because of the nested for into the foreach
    public List<List<int>> Permute(int[] nums)
    {
        var result = new List<List<int>>();
        if (nums.Length == 0)
            return new List<List<int>> { new() };

        var permutations = Permute(nums[1..]);
        
        
        foreach (var permutation in permutations)
        {
            for (int insertIndex = 0; insertIndex <= permutation.Count; insertIndex++)
            {
                var currentPermutation = permutation.ToList();
                currentPermutation.Insert(insertIndex, nums[0]);
                result.Add(currentPermutation); 
            }
        }

        return result;
    }
}