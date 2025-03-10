using FluentAssertions;
using LinkedList.Main.ReverseList;

namespace testCases;

public class ReverseLinkedList_Test
{
    [Test]
    public void Test_Example_1_Recursively()
    {
        ListNode input = new(1, new(2, new(3, new(4, new(5)))));

        Solution solution = new();
        ListNode testResult = solution.ReverseListRecursively(input);

        testResult.val.Should().Be(5);
        testResult.next.val.Should().Be(4);
        testResult.next.next.val.Should().Be(3);
        testResult.next.next.next.val.Should().Be(2);
        testResult.next.next.next.next.val.Should().Be(1);
    }
    
    [Test]
    public void Test_Example_1_Iteratively()
    {
        ListNode input = new(1, new(2, new(3, new(4, new(5)))));

        Solution solution = new();
        ListNode testResult = solution.ReverseListIteratively(input);

        testResult.val.Should().Be(5);
        testResult.next.val.Should().Be(4);
        testResult.next.next.val.Should().Be(3);
        testResult.next.next.next.val.Should().Be(2);
        testResult.next.next.next.next.val.Should().Be(1);
    }

    [Test]
    public void Test_Example_2()
    {
        ListNode input = new(1, new(2));

        Solution solution = new();
        ListNode testResult = solution.ReverseListRecursively(input);

        testResult.val.Should().Be(2);
        testResult.next.val.Should().Be(1);
    }

    [Test]
    public void Test_Example_3()
    {
        ListNode input = null;

        Solution solution = new();
        ListNode testResult = solution.ReverseListRecursively(input);

        testResult.Should().BeNull();
    }
}