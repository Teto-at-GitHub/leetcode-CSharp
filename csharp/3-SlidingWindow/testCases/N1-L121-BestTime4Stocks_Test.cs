
using FluentAssertions;
using NUnit.Framework;
using SlidingWindow.Main.BestTime4Stocks;

namespace testCases;

public class BestTime4Stocks_Test
{

   [Test]
   public void Test_Example_1()
   {
      int[] prices = {7, 1, 5, 3, 6, 4};

      Solution solution = new Solution();
      int testResult = solution.MaxProfit(prices);

      testResult.Should().Be(5);
   }

   [Test]
   public void Test_Example_2()
   {
      int[] prices = { 7, 6, 4, 3, 1 };

      Solution solution = new Solution();
      int testResult = solution.MaxProfit(prices);

      testResult.Should().Be(0);
   }
}