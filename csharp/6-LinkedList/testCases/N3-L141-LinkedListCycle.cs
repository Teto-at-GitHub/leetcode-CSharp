using FluentAssertions;
using LinkedList.Main.LinkedListCycle;
using NUnit.Framework;

namespace testCases
{
   public class LinkedListCycle_Test
   {
      [Test]
      public void Test_Example_1()
      {
         ListNode headNode = new(3);
         headNode.next = new(2);
         headNode.next.next = new(0);
         ListNode last = headNode.next.next.next = new(-4);
         // cycle
         last.next = headNode.next;

         Solution solution = new();
         bool testResult = solution.HasCycle(headNode);

         testResult.Should().Be(true);
      }
   }
}