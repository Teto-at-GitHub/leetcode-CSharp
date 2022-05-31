using System;
using System.Collections;
using System.Collections.Generic;

namespace lintcode
{

   //   Definition of Interval:
   public class Interval
   {
      public int start, end;
      public Interval(int start, int end)
      {
         this.start = start;
         this.end = end;
      }
   }

   class Solution
   {
      /**
       * @param intervals: an array of meeting time intervals
       * @return: if a person could attend all meetings
       **/
      public bool CanAttendMeetings(List<Interval> intervals)
      {
         // Write your code here
         intervals.Sort(SortByStartTimeHeleper.CompareStartTime);

         for (int i = 1; i < intervals.Count; i++)
         {
            Interval i1 = intervals[i-1];
            Interval i2 = intervals[i];

            if (i1.end > i2.start)
               return false;
         }
         return false;
      }

   }

   public class SortByStartTimeHeleper
   {
      public static int CompareStartTime(object? x, object? y)
      {
         Interval a = (Interval)x;
         Interval b = (Interval)y;

         if (a.start > b.start)
            return 1;
         if (a.start < b.start)
            return -1;
         
         return 0;
      }

   }

    

}