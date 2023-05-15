using System;

namespace Sample12
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] a = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if(target == (nums[i] + nums[j]))
                    {
                        a[0] = i;
                        a[1] = j;
                    }
                }
            }

            return a;
        }

        public static void Main()
        {
            int[] nums = {3,2,4};
            int target = 6;
            Solution obj = new Solution();
            int[] a = obj.TwoSum(nums, target);

            Console.WriteLine("[" + a[0] + "," + a[1] + "]");

            //int x = 10;
            //int y = 20;
            //int z = ((x++)++)+y;
            //Console.WriteLine(z);
            int x = 'A';
            Console.WriteLine(x);
        }
    }
}
