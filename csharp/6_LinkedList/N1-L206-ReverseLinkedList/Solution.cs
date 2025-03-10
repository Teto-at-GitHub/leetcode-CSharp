namespace LinkedList.Main.ReverseList
{
   // Definition for singly-linked list.
   public class ListNode
   {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
      {
         this.val = val;
         this.next = next;
      }
   }

   public class Solution
   {
      // Iterative
      // TC : O(n)
      // SC : O(1)
      public ListNode ReverseListIteratively(ListNode head)
      {
         ListNode previous = null;
         ListNode current = head;

         while (current is not null)
         {
            ListNode next = current.next;
            current.next = previous;
            previous = current;
            current = next;
         }

         return previous;
      }

      // recursive
      // TC : O(n)
      // SC : O(n), 
      public ListNode ReverseListRecursively(ListNode head)
      {
         if (head is null)
            return head;

         ListNode newHead = head;
         if (head.next is not null)
         {
            newHead = ReverseListRecursively(head.next);
            head.next.next = head;
         }
         head.next = null;

         return newHead;
      }
   }
}
