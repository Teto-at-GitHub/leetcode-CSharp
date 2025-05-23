using System.ComponentModel.Design;
using _18_BitManipulation.L191_NumberOfOneBits;
using FluentAssertions;
using NUnit.Framework;

namespace _18_BitManipulation_Tests;

public class L191_NumberOfOneBits_Tests
{
    [Test]
    public void Example1_Test()
    {
        uint input = 0b10111;
        
        var solution = new Solution();
        var result = solution.HammingWeightByMod(input);

        result.Should().Be(4);
    }

    [Test]
    public void Example2_Test()
    {
        uint input = 0b01111111111111111111111111111101;
        
        var solution = new Solution();
        var result = solution.HammingWeightByMod(input);

        result.Should().Be(30);
    }
}