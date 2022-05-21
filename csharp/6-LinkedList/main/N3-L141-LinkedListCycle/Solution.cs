namespace LinkedList.Main.LinkedListCycle
{
   // WARNING - this definition is slightly different than the one in N1 and N2 :
   // the constructor only takes one arg
   //   Definition for singly-linked list. 
   public class ListNode
   {
      public int val;
      public ListNode next;
      public ListNode(int x)
      {
         val = x;
         next = null;
      }
   }

   public class Solution
   {
      public bool HasCycle(ListNode head)
      {
         return false;
      }
   }
}




