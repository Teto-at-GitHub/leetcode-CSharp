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

   // Hashset sol takes
   // time : O(n)
   // space : O(n)


   // Floyd's tortoise and hare
   // if there is a cycle, the slow and the fast pointer they meet again
   // time : O(n)
   public class Solution
   {
      public bool HasCycle(ListNode head)
      {
         ListNode slow = head;
         ListNode fast = head;

         while (fast is not null && fast.next is not null)
         {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
               return true;
         }

         return false;
      }
   }
}




