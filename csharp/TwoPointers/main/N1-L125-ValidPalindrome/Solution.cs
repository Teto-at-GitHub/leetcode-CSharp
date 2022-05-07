using System.Text.RegularExpressions;

namespace TwoPointers.Main.ValidPalindrome
{
   public class Solution
   {
      public bool IsPalindrome(string s)
      {
         List<char> cleanInput = new();
         foreach (char item in s)
         {
            Regex regex = new Regex("[a-zA-Z0-9]");
            Match match = regex.Match(item.ToString());

            if (match.Success)
               cleanInput.Add(item.ToString().ToLower().ElementAt(0));
         }

         int cleanInputLength = cleanInput.Count;
         for (int i = 0; i < cleanInputLength / 2; i++)
         {
            if (cleanInput[i] != cleanInput[cleanInputLength - 1 - i])
               return false;
         }

         return true;
      }
   }
}