namespace _11_BackTracking.L1863_SumOfAllSubsetsXorTotal;

public class Solution {
    public int SubsetXORSum(int[] nums)
    {
        var result = 0;

        depthFirstSearch(0, 0);
        
        return result;
        
        void depthFirstSearch(int i, int total)
        {
            result += total;
            
            if (i >= nums.Length)
                return;

            depthFirstSearch(i, nums[i] ^ total);
            depthFirstSearch(i+1, total);            
        }
    }

    
}