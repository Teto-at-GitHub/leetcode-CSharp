using ArrayAndHashing.Main.TwoSum;
using FluentAssertions;
using NUnit.Framework;

namespace testCases
{
   public class TwoSum_Test
   {
      [Test]
      public void Test_Example_1()
      {
         int[] nums = {2,7,11,15};
         int target = 9;

         Solution solution = new Solution();
         int[] testResult = solution.TwoSum(nums,target);

         testResult[0].Should().Be(0);
         testResult[1].Should().Be(1);
         
      }

      [Test]
      public void Test_Example_2()
      {
         int[] nums = { 3,2,4 };
         int target = 6;

         Solution solution = new Solution();
         int[] testResult = solution.TwoSum(nums, target);

         testResult[0].Should().Be(1);
         testResult[1].Should().Be(2);
      }

       [Test]
       public void Test_Example_3()
      { 
         int[] nums = { 3,3 };
         int target = 6;

         Solution solution = new Solution();
         int[] testResult = solution.TwoSum(nums, target);

         testResult[0].Should().Be(0);
         testResult[1].Should().Be(1);

      }

  }
}