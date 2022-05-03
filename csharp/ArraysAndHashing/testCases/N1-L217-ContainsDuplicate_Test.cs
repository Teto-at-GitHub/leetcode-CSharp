using NUnit.Framework;
using ArrayAndHashing.Main.ContainsDuplicate;
using FluentAssertions;

namespace testCases;

public class ContainsDuplicate_Test
{
  [Test]
  public void TestCase_1()
  {
    // Arrange
    int[] input = { 1, 2, 3, 1 };

    // Act
    Solution solution = new Solution();
    bool testResult = solution.ContainsDuplicate(input);

    // Assert
    testResult.Should().Be(true);
  }

  [Test]
  public void TestCase_2()
  {
    int[] input = { 1, 2, 3, 4 };

    // Act
    Solution solution = new Solution();
    bool testResult = solution.ContainsDuplicate(input);

    // Assert
    testResult.Should().Be(false);
  }

  [Test]
  public void TestCase_3()
  {
    int[] input = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

    Solution solution = new Solution();
    bool testResult = solution.ContainsDuplicate(input);

    testResult.Should().Be(true);
  }
}