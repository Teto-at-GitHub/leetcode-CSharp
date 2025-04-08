namespace _11_BackTracking.L1863_SumOfAllSubsetsXorTotal;

public class Solution {
    
    // Time complexity: O(2^N)
    // Space complexity: O(N)
    public int SubsetXORSum(int[] nums)
    {
        var result = 0;

        return depthFirstSearch(0, 0);
        
        int depthFirstSearch(int i, int total)
        {
            result += total;
            
            if (i == nums.Length)
                return total;

            var sumIncludingCurrentElement = depthFirstSearch(i+1, nums[i] ^ total);
            var sumExcludingCurrentElement = depthFirstSearch(i+1, total);

            return sumIncludingCurrentElement + sumExcludingCurrentElement;
        }
    }

    
}