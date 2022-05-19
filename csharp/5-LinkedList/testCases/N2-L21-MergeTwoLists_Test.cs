using FluentAssertions;
using LinkedList.Main.MergeTwoLists;
using NUnit.Framework;

namespace testCases
{
   public class MergeTwoLinkedList_Test
   {
      [Test]
      public void Test_Example_1()
      {
         ListNode input1 = new(1, new(2, new(4)));
         ListNode input2 = new(1, new(3, new(4)));

         Solution solution = new();
         ListNode testResult = solution.MergeTwoLists(input1,input2);

         testResult.val.Should().Be(1);
         testResult.next.val.Should().Be(1);
         testResult.next.next.val.Should().Be(2);
         testResult.next.next.next.val.Should().Be(3);
         testResult.next.next.next.next.val.Should().Be(4);
         testResult.next.next.next.next.next.val.Should().Be(4);
      }

      [Test]
      public void Test_Example_2()
      {
         ListNode input1 = new();
         ListNode input2 = new();

         Solution solution = new();
         ListNode testResult = solution.MergeTwoLists(input1,input2);

         testResult.val.Should().Be(null);
      }

      [Test]
      public void Test_Example_3()
      {
         ListNode input1 = new();
         ListNode input2 = new(0);

         Solution solution = new();
         ListNode testResult = solution.MergeTwoLists(input1, input2);

         testResult.val.Should().Be(null);
         testResult.next.val.Should().Be(0);
      }
   }
}

