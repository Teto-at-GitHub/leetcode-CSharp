using _11_BackTracking.Permutations;
using FluentAssertions;
using NUnit.Framework;

namespace _11_BackTracking_Tests;

public class PermutationTests
{
    [Test]
    public void TestExample0()
    {
        var nums = new[] { 7, 5 };

        var expectedResult = new List<List<int>>()
        {
            new() { 5, 7 },
            new() { 7, 5 }
        };
        
        var solution = new Solution();
        var result = solution.Permute(nums);
        
        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void TestExample1()
    {
        var nums = new[] { 1, 2, 3 };

        var expectedResult = new List<List<int>>()
        {
            new() { 1, 2, 3 },
            new() { 1, 3, 2 },
            new() { 2, 1, 3 },
            new() { 2, 3, 1 },
            new() { 3, 1, 2 },
            new() { 3, 2, 1 }
        };

        var solution = new Solution();
        var result = solution.Permute(nums);
        
        result.Should().BeEquivalentTo(expectedResult);
    }
}