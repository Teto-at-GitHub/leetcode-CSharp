using FluentAssertions;
using NUnit.Framework;

namespace _18_BitManipulation_Tests;

public class L338_CountingBits_Tests
{
    [Test]
    public void Example1_Tests()
    {
        var input = 4;

        var solution = new _18_BitManipulation.L338_CountingBits.Solution();
        var result = solution.CountBits(input);

        result.Length.Should().Be(input + 1);
        result[0].Should().Be(0);
        result[1].Should().Be(1);
        result[2].Should().Be(1);
        result[3].Should().Be(2);
        result[4].Should().Be(1);
    }
}