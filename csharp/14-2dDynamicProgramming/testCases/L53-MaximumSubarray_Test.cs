using FluentAssertions;
using NUnit.Framework;
using TwoDimDynamicProgrammin.Main.MaximumSubarray;

namespace testCases;

public class MaximumSubarray_Test
{
   [Test]
   public void Test_Example_1()
   {
      int[] input = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

      Solution solution = new();
      int testResult = solution.MaxSubArray(input);

      testResult.Should().Be(6);
   }

   [Test]
   public void Test_Example_2()
   {
      int[] input = {1};

      Solution solution = new();
      int testResult = solution.MaxSubArray(input);

      testResult.Should().Be(1);
   }

   [Test]
   public void Test_Example_3()
   {
      int[] input = {5, 4, -1, 7, 8 };

      Solution solution = new();
      int testResult = solution.MaxSubArray(input);

      testResult.Should().Be(23);
   }

   [Test]
   public void Test_Example_4()
   {
      int[] input = {-1};

      Solution solution = new();
      int testResult = solution.MaxSubArray(input);

      testResult.Should().Be(-1);
   }
}