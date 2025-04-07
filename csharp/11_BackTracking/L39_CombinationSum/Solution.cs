namespace _11_BackTracking.L39_CombinationSum;

public class Solution
{
    public List<List<int>> CombinationSum(int[] nums, int target)
    {
        var result = new List<List<int>>();

        depthFirstSearch(0, new List<int>(), 0);

        return result;

        void depthFirstSearch(int index, List<int> current, int total)
        {
            if (total == target)
            {
                // the .ToList() is used to copy current into a new one here,
                // otherwise it keeps getting updated
                result.Add(current.ToList());
                return;
            }

            if (index >= nums.Length || total > target)
                return;

            current.Add(nums[index]);
            depthFirstSearch(index, current, total + nums[index]);
            current.Remove(current.Last());
            depthFirstSearch(index + 1, current, total);
        }
    }
}