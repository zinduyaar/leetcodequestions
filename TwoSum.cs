using System;
// 19th Feb 2021
// https://leetcode.com/problems/two-sum/

public class Solution
{

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                var combinator = target - nums[i];
                var combinatorIndex = Array.FindIndex(nums, w => w == combinator);

                if (combinatorIndex >= 0 && combinatorIndex != i)
                {
                    result[0] = i;
                    result[1] = combinatorIndex;
                    break;
                }
            }
            return result;
        }
    }
}