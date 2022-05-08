using System.Text.RegularExpressions;

namespace TwoPointers.Main.ValidPalindrome
{
   public class Solution
   {
      // I am not sure of the complexity of my solution :-(
      public bool IsPalindrome(string s)
      {
         //FIRST SUBMISSION
         // List<char> cleanInput = new();
         // foreach (char item in s)
         // {
         //    Regex regex = new Regex("[a-zA-Z0-9]");
         //    Match match = regex.Match(item.ToString());

         //    if (match.Success)
         //       cleanInput.Add(item.ToString().ToLower().ElementAt(0));
         // }

         // A bit slower
         // int cleanInputLength = cleanInput.Count;
         // for (int i = 0; i < cleanInputLength / 2; i++)
         // {
         //    if (cleanInput[i] != cleanInput[cleanInputLength - 1 - i])
         //       return false;
         // }

         // FINAL submission
         // I like this solution because :
         // - it's faster than the previous one : 81 < 586
         // - it uses built-in fcts to perform the checks :
         //    - if a char is alphanumeric
         //    - if the cleaned up string is a palindrome
         // - it reduces the ammount of back and forth between char list or arrays and strings
         string str = s.ToLower();
         char[] cleaInputCharArr = str.Where(c => Char.IsLetterOrDigit(c)).ToArray();

         string cleanInputString = new(cleaInputCharArr);
         Array.Reverse(cleaInputCharArr);
         string reversedString = new(cleaInputCharArr);
         if (cleanInputString == reversedString)
            return true;

         return false;
      }

      // **BEST**
      // This solution ( taken from LeetCode) is super fast (51 ms) and actually uses pointers
      // It's the C# version of the one suggested by NeetCode
      // time complexity : O(n)
      // memory complexity : O(1)
      public bool IsPalindromeInsane(string st)
      {
         var s = st.ToLower();

         int left = 0;
         int right = s.Length - 1;

         while (left < right)
         {
            while (left < right && !Char.IsLetterOrDigit(s[left]))
            {
               left++;
            }
            while (left < right && !Char.IsLetterOrDigit(s[right]))
            {
               right--;
            }

            if (s[left] != s[right])
            {
               return false;
            }
            left++;
            right--;
         }

         return true;
      }
   }


}