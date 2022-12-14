using System;

namespace practice_221214
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 2, 1 };
            int[] nums2 = { 4, 1, 2, 1, 2 };
            int[] nums3 = { 1 };

            var find = new Solution();
            find.SingleNumber(nums1);
            find.SingleNumber(nums2);
            find.SingleNumber(nums3);
        }
    }
    // 給定一個非空的整數陣列nums，裡面每一個元素都出現兩次，除了一個single one。請回傳該值。
    //Example 1:
    //Input: nums = [2,2,1]
    //Output: 1

    //Example 2:
    //Input: nums = [4,1,2,1,2]
    //Output: 4

    //Example 3:
    //Input: nums = [1]
    //Output: 1
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int i, j, len, count = 0;
            len = nums.GetUpperBound(0);
            for (i = 0; i <= len; i++)
            {
                for (j = 0; j <= len; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
                if (count != 2)
                {
                    return nums[i];
                }
            }
        }
    }
}
