using FluentAssertions;
using NUnit.Framework;
using Stack.Main.ValidParentheses;

namespace testCases;

public class ValidParentheses_Tests
{

   [Test]
   public void Test_Example_1()
   {
      string input = "()";

      Solution solution = new();
      bool testResult = solution.IsValid(input);

      testResult.Should().Be(true);
   }

   [Test]
   public void Test_Example_2()
   {
      string input = "()[]{}";

      Solution solution = new();
      bool testResult = solution.IsValid(input);

      testResult.Should().Be(true);
   }

   [Test]
   public void Test_Example_3()
   {
      string input = "(]";

      Solution solution = new();
      bool testResult = solution.IsValid(input);

      testResult.Should().Be(false);
   }

   [Test]
   public void Test_Example_4()
   {
      string input = "{[()]}";

      Solution solution = new();
      bool testResult = solution.IsValid(input);

      testResult.Should().Be(true);
   }
}