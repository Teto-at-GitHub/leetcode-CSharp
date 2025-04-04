using _16_Intervals.L252_MeetingRoom;
using FluentAssertions;
using NUnit.Framework;

namespace _16_Intervals_Tests;

public class L252_IntervalsTests
{
    [Test]
    public void Example1_Test()
    {
        var intervals = new List<Interval>()
        {
            new(0, 30),
            new(5, 10),
            new(15, 20)
        };

        var solution = new Solution();
        var result = solution.CanAttendMeetings(intervals);

        result.Should().Be(false);
    }

    [Test]
    public void Example2_Test()
    {
        var intervals = new List<Interval>()
        {
            new(5, 8),
            new(9, 15)

        };
        var solution = new Solution();
        var result = solution.CanAttendMeetings(intervals);

        result.Should().Be(true);
    }

}
