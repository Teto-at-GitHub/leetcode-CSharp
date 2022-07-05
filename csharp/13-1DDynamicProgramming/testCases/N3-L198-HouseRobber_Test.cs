using FluentAssertions;
using NUnit.Framework;
using OneDimDynamicProgramming.Main.HouseRobber;

namespace testCases;

public class HouseRobber_Test
{
   [Test]
   public void Test_Example_1()
   {
      int[] input = {1,2,3,1};

      OneDimDynamicProgramming.Main.HouseRobber.Solution solution = new();
      int test_result = solution.Rob(input);

      test_result.Should().Be(4);
   }

   [Test]
   public void Test_Example_2()
   {
      int[] input = { 2, 7, 9, 3, 1 };

      OneDimDynamicProgramming.Main.HouseRobber.Solution solution = new();
      int test_result = solution.Rob(input);

      test_result.Should().Be(12);
   }
}