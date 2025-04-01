namespace _18_BitManipulation.L191_NumberOfOneBits;

public class Solution {
    public int HammingWeightByMod(uint n)
    {
        var numberOfOnes = 0;
        
        for (int i = 0; i < 32; i++)
        {
            // select the order of magnitued in base 2
            // by bit-shifting 1
            var shiftedI = 1 << i;
            
            // bitwise logical AND
            // 0 * 0 = 0
            // 0 * 1 = 0
            // 1 * 1 = 1
            var bitWiseMultip = shiftedI & n;

            // increase number of 1 bits
            if (bitWiseMultip != 0) 
                numberOfOnes++;
        }

        return numberOfOnes;
    }
}
