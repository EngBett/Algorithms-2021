using System;
using System.Collections.Generic;

namespace Algorightms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //;p
        }
    }
    
    public static class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            var store = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var res = target - nums[i];

                if (store.Contains(res)) return new int[] {store.IndexOf(res), i};

                store.Add(nums[i]);
            }

            return Array.Empty<int>();
        }
    }
}