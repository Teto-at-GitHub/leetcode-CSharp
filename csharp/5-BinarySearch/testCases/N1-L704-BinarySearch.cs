using NUnit.Framework;
using FluentAssertions;
using BinarySearch.Main.BinarySearch;

namespace testCases;

public class BinarySearch_Test
{

   [Test]
   public void Test_Example_1()
   {
      int[] inputNums = {-1, 0, 3, 5, 9, 12};
      int target = 9;

      Solution solution = new();
      int testResult = solution.Search(inputNums,target);

      testResult.Should().Be(4);
   }

   [Test]
   public void Test_Example_2()
   {
      int[] inputNums = { -1, 0, 3, 5, 9, 12 };
      int target = 2;

      Solution solution = new();
      int testResult = solution.Search(inputNums, target);

      testResult.Should().Be(-1);
   }
}