using ArrayAndHashing.Main.Validanagram;
using FluentAssertions;
using NUnit.Framework;

namespace testCases
{
  public class ValidAnagram_Test
  {
     
   [Test]
    public void Test_Example_1()
    {
      // Arrange
      string s = "anagram";
      string t = "nagaram";

      // Act
      Solution solution = new Solution();
      bool testResult = solution.IsAnagram(s,t);

      // Assert
      testResult.Should().Be(true);
    }

    [Test]
    public void Test_Example_2()
    {
      // Arrange
      string s = "rat";
      string t = "car";

      // Act
      Solution solution = new Solution();
      bool testResult = solution.IsAnagram(s, t);

      // Assert
      testResult.Should().Be(false);
    }

    [Test]
    public void Test_Example_3()
    {
      string s = "aacc";
      string t = "ccac";

      Solution solution = new Solution();
      bool testResult = solution.IsAnagram(s, t);

      // Assert
      testResult.Should().Be(false);
    }
  }
}