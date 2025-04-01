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
        var x = input << 1;
        byte a = 3;
        byte b = 0b_0011;
        bool c = a == b;
        
        
        var solution = new Solution();
        var result = solution.HammingWeightByMod(input);

        result.Should().Be(4);

    }
}