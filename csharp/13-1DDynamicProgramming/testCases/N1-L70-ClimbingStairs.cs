using FluentAssertions;
using NUnit.Framework;
using OneDimDynamicProgramming.Main.ClimbingStairs;

namespace testCases;

public class ClimbingStairs_Test
{

    [Test]
    public void Test_Example_1()
    {
        Solution solution = new();
        int testResult = solution.ClimbStairs(2);

        testResult.Should().Be(2);
    }

   [Test]
    public void Test_Example_2()
    {
        Solution solution = new();
        int testResult = solution.ClimbStairs(3);

        testResult.Should().Be(3);
    }
}