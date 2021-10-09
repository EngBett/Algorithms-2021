using System;
using System.Linq;

namespace MinStepsToMakePilesEqualHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinSteps(new []{5,2,1}));
        }

        static int MinSteps(int[] nums)
        {
            var sortedList = nums.OrderByDescending(c => c).ToArray();

            int count = 0;
            int pileValues = 0;
            
            for (int i = 0; i < sortedList.Length; i++)
            {

                if(i == sortedList.Length-1) continue;
                
                if (nums[i] == nums[i + 1])
                {
                    count += pileValues;
                    continue;
                }

                pileValues++;
                count += pileValues;
            }
            
            return count;
        }
    }
}