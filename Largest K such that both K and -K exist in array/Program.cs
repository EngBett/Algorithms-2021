using System;
using System.Linq;

namespace Largest_K_such_that_both_K_and__K_exist_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestKforKminusK(new []{-5,-3,-1,1,2,3}));
        }

        static int LargestKforKminusK(int[] nums)
        {
            var sortedNums = nums.OrderBy(n => n).ToArray(); //->O(n) -> .net's worst case for sorting is O(n)

            int l = 0, r = sortedNums.Length-1;
            while (l < r)
            {
                if (sortedNums[r] + sortedNums[l] == 0) return Math.Abs(sortedNums[r]);

                if (sortedNums[r] + sortedNums[l] > 0)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }
            
            return 0;
        }
    }
}