using NUnit.Framework;
using ArrayAndHashing.Main.ContainsDuplicate;
using FluentAssertions;

namespace testCases;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestCase_1()
    {
        // Arrange
        int[] input = {1, 2, 3, 1};

        // Act
        Solution solution = new Solution();
        bool testResult = solution.ContainsDuplicate(input);

        // Assert
        testResult.Should().Be(true);
    }
}