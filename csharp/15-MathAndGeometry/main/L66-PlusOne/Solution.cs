namespace MathAndGeometry.Main.PlusOne;
public class Solution
{
   public int[] PlusOne(int[] digits)
   {
      int last_index = digits.Length - 1;
      digits[last_index]++;

      int index = last_index;
      while (digits[index] == 10 && index >= 0)
      {
         // set digit to zero
         digits[index] = 0;
         // move pointer to next digit
         index--;
         if (index == -1)
         {
            int[] longerArray = new int[digits.Length + 1];
            longerArray[0] = 1;
            Array.Copy(digits, 0, longerArray, 1, digits.Length);
            return longerArray;
         }
         // add the carry
         digits[index]++;
      }
      

      return digits;
   }
}