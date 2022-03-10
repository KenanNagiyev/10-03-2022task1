using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 3, 8, 5, 1, 6, 9, 7 };
            Console.WriteLine(MinMax(nums));
        }
        static int MinMax(int[] nums)
        {

            int min = nums[0];
            int max = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {

                    min = nums[i];
                    Console.WriteLine(nums[i]);
                }
                if (nums[i] > max)
                {

                    max = nums[i];
                    Console.WriteLine(nums[i]);
                }

                min = max;
            }
            return min ;
        }
        }
}
