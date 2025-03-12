using System;
using System.ComponentModel.DataAnnotations;
using FluentAssertions;
using MathAndGeometry.Main.HappyNumber;
using NUnit.Framework;

namespace testCases;

public class HappyNumber_Test
{

   [Test]
   public void Test_Example_1()
   {
      int inputTest1 = 19;

      Solution solution = new();
      bool testResult = solution.IsHappy(inputTest1);

      testResult.Should().Be(true);
   }

   [Test]
   public void Test_Example_2()
   {
      int inputTest1 = 2;

      Solution solution = new();
      bool testResult = solution.IsHappy(inputTest1);

      testResult.Should().Be(false);
   }
}