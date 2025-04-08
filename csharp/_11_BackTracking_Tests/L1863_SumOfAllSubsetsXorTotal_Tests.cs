using _11_BackTracking.L1863_SumOfAllSubsetsXorTotal;
using FluentAssertions;
using NUnit.Framework;

namespace _11_BackTracking_Tests;

public class L1863_SumOfAllSubsetsXorTotal_Tests
{
    [Test]
    public void Example2_Test()
    {
        var nums = new int[] { 5, 1, 6 };

        var solution = new Solution();
        var result = solution.SubsetXORSum(nums);

        result.Should().Be(28);
    }


}