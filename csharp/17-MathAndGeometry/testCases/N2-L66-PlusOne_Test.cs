using FluentAssertions;
using MathAndGeometry.Main.PlusOne;
using NUnit.Framework;

namespace testCases;

public class PlusOne_Test
{

   [Test]
   public void Test_Example_1()
   {
      int[] inputTest1 = {1,2,3};
      int[] expectedOutput1 = {1,2,4};

      Solution solution = new();
      int[] testResult = solution.PlusOne(inputTest1);

      testResult.Should().Equal(expectedOutput1);
   }

   [Test]
   public void Test_Example_2()
   {
      int[] inputTest = { 1, 9, 9 };
      int[] expectedOutput = { 2, 0, 0 };

      Solution solution = new();
      int[] testResult = solution.PlusOne(inputTest);

      testResult.Should().Equal(expectedOutput);
   }

   [Test]
   public void Test_Example_3()
   {
      int[] inputTest = { 9, 9, 9 };
      int[] expectedOutput = { 1, 0, 0, 0 };

      Solution solution = new();
      int[] testResult = solution.PlusOne(inputTest);

      testResult.Should().Equal(expectedOutput);
   }

}