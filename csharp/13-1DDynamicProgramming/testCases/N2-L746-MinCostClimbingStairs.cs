using FluentAssertions;
using NUnit.Framework;
using OneDimDynamicProgramming.Main.MinCostClimbingStairs;

namespace testCases;

public class MinCostClimbingStairs_Test
{

   [Test]
   public void Test_Example_1()
   {
      int[] input = {10,15,20};

      Solution solution = new();
      int testResult = solution.MinCostClimbingStairs(input);

      testResult.Should().Be(15);
   }

   [Test]
   public void Test_Example_2()
   {
      int[] input = {1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };

      Solution solution = new();
      int testResult = solution.MinCostClimbingStairs(input);

      testResult.Should().Be(6);
   }
}