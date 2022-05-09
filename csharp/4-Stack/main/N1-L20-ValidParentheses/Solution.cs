namespace Stack.Main.ValidParentheses
{
   public class Solution
   {
      // time complexity : O(n) <-- string is traversed only once
      // space complexity : O(n) <-- max size of the stack
      public bool IsValid(string s)
      {

         if (s.Length %2 != 0)
            return false;

         Stack<char> stack = new();
         Dictionary<char, char> closeOpenBracketsMatch = new()
         {
            {')','('},
            {']','['},
            {'}','{'}
         };

         foreach (char c in s)
         {
            if (closeOpenBracketsMatch.ContainsKey(c))
            {
               if (stack.Count != 0 && stack.Peek() == closeOpenBracketsMatch[c])
                  stack.Pop();
               else 
                  return false;
            }
            else
               stack.Push(c);
         }

         return stack.Count == 0 ? true : false; 
      }
   }

}