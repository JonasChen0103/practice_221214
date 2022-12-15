using System;
using System.Collections.Generic;
using System.Linq;

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

    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            var dic = new Dictionary<int, byte>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], 1);
                else
                    dic[nums[i]]++;
            }


            #region 末段Solution1

            foreach (var item in dic)
            {
                if (item.Value == 1)
                    return item.Key;
            }                           

            throw new ArgumentException();
            #endregion


            #region 末段Solution2

            var singleNum = dic.Where(d => d.Value == 1)
                   .Select(d => d.Key)
                   .First();
            return singleNum;
            #endregion
        }
    }
}
