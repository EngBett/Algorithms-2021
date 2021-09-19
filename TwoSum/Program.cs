﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class Algo
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