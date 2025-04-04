using _11_BackTracking.L39_CombinationSum;
using FluentAssertions;
using NUnit.Framework;

namespace _11_BackTracking_Tests;

public class L39_CombinationSum_Tests
{
    [Test]
    public void Example1_Test()
    {
        int[] numbers = new[] { 2, 5, 6, 9 };
        int target = 9;

        var solution = new Solution();
        var result = solution.CombinationSum(numbers, target);

        result.Count.Should().Be(2);
        result[0].Should().BeEquivalentTo(new List<int>() { 2, 2, 5 });
        result[1].Should().BeEquivalentTo(new List<int>() { 9 });
    }
    
}