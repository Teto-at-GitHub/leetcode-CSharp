using FluentAssertions;
using NUnit.Framework;
using TwoPointers.Main.ValidPalindrome;

namespace testCases
{
   public class ValidPalindrome_Test
   {

      [Test]
      public void Test_Example_1()
      {
         // Arrange
         string input = "A man, a plan, a canal: Panama";
         // Act
         Solution solution = new Solution();
         bool testResult = solution.IsPalindrome(input);

         // Assert
         testResult.Should().Be(true);
      }

      [Test]
      public void Test_Example_2()
      {
         // Given
         string input = "race a car";

         // When
         Solution solution = new Solution();
         bool testResult = solution.IsPalindromeInsane(input);
      
         // Then
         testResult.Should().Be(false);
      }

      [Test]
      public void Test_Example_3()
      {
         // Given
         string input = " ";

         // When
         Solution solution = new Solution();
         bool testResult = solution.IsPalindrome(input);

         // Then
         testResult.Should().Be(true);
      }
   }
}