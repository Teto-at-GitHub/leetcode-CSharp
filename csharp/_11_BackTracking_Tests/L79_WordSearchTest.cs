using _11_BackTracking.WordSearch;
using FluentAssertions;
using NUnit.Framework;

namespace _11_BackTracking_Tests;

public class L79_WordSearchTest
{
    [Test]
    public void TestExample1()
    {
        var board = new char[][]
        {
            ['A', 'B', 'C', 'D'],
            ['S', 'A', 'A', 'T'],
            ['A', 'C', 'A', 'E']
        };

        var solution = new Solution();
        var result = solution.Exist(board, "CAT");

        result.Should().BeTrue();
    }

    [Test]
    public void TestExample2()
    {
        var board = new char[][]
        {
            ['A', 'B', 'C', 'D'],
            ['S', 'A', 'A', 'T'],
            ['A', 'C', 'A', 'E']
        };

        var solution = new Solution();
        var result = solution.Exist(board, "BAT");

        result.Should().BeFalse();

        // we expect the iterations to be at least as big as r*c
        var expectedIterationsWorstCase = (int)(board.Length * board[0].Length * Math.Pow(4, 3));
        solution.Iterations.Should().BeLessOrEqualTo(expectedIterationsWorstCase);
    }
}