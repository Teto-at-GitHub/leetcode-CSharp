# L252 - Meeting Rooms


Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si < ei), determine if a person could attend all meetings.

## Example1

Input: intervals = [(0,30),(5,10),(15,20)]

Output: false

Explanation: 

(0,30), (5,10) and (0,30),(15,20) will conflict

## Example2

Input: intervals = [(5,8),(9,15)]

Output: true

Explanation: 

Two times will not conflict

## Constraints
- 0 <= intervals.length <= 500
- 0 <= intervals[i].start < intervals[i].end <= 1,000,000
