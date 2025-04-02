namespace _18_BitManipulation.L338_CountingBits;

// time complexity: O(n)
// this is just a loop over the NumberOfOneBits Solution,
// which here I wrote in a more compact form
public class Solution {
    public int[] CountBits(int n)
    {
        var result = new int[n+1];

        for (int i = 0; i < n+1; i++)
        {
            var numberOfOnes = 0;
            
            for (int j = 0; j < 32; j++)
            {
                numberOfOnes += ((1 << j) & i) == 0 ? 0 : 1;
            }
            
            result[i] = numberOfOnes;
        }
        
        return result;
    }
}
