using FluentAssertions;
using Graphs.Main.NumberOfIslands;
using NUnit.Framework;

namespace testCases;

public class NumberOfIsland_Test
{
    [Test]
    public void ExampleTest1()
    {
        char[][] inputGrid = new[]
        {
            new[] { '1', '1', '1', '1', '0' },
            new[] { '1', '1', '0', '0', '0' },
            new[] { '0', '0', '1', '0', '0' },
            new[] { '0', '0', '0', '1', '1' }
        };

        Solution solution = new();
        int testOutput = solution.NumIslands(inputGrid);

        testOutput.Should().Be(3);
    }

    [Test]
    public void ExampleTest2()
    {
        char[][] inputGrid = new[]
        {
            new[] { '1', '1', '0', '0', '1' },
            new[] { '1', '1', '0', '0', '1' },
            new[] { '0', '0', '1', '0', '0' },
            new[] { '0', '0', '0', '1', '1' }
        };

        Solution solution = new();
        int testOutput = solution.NumIslands(inputGrid);

        testOutput.Should().Be(4);
    }
}