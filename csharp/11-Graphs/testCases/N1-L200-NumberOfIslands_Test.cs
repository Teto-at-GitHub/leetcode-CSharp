using FluentAssertions;
using Graphs.Main.NumberOfIslands;
using NUnit.Framework;

namespace testCases;

public class NumberOfIsland_Test
{
   [Test]
   public void Example_Test_1()
   {
      char[][] inputGrid = new char[][] {
      new char[] {'1', '1', '1', '1', '0'},
      new char[] {'1', '1', '0', '0', '0'},
      new char[] {'0', '0', '1', '0', '0'},
      new char[] {'0', '0', '0', '1', '1'}
      };

      Solution solution = new();
      int testOutput = solution.NumIslands(inputGrid);

      testOutput.Should().Be(3);
   }
}