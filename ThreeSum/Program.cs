using System;
using System.Collections.Generic;
using System.Linq;

namespace ThreeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new[] {-1, 0, 1, 2, -1, -4};
            /*var expected = new List<int[]>()
            {
                new []{-1,-1,2},
                new []{-1,0,1}
            }*/;
            var result = ThreeSumAlgo.Solution(nums);

            foreach (var i_s in result)
            {
                foreach (var i in i_s)
                {
                    Console.Write($"{i}, ");
                }

                Console.WriteLine();
            }
            
            Console.WriteLine("Hello World!");
        }
    }
    
    public class ThreeSumAlgo
    {
        public static IList<IList<int>> Solution(int[] nums) {
            var myList = nums.ToList();
            var i=0;
            var result = new List<int[]>();
            var visited = new HashSet<int>();
            
            while(i < myList.Count-3){
                
                
                var store = new List<int>();
                var wList = myList.Where((_,index)=>index!=i).ToList();
                var target = 0 - myList[i];
            
                
                foreach (var t in wList)
                {
                    if(store.Contains(target-t)){
                        if(visited.Contains(i)) continue;

                        visited.Add(i);
                        
                        result.Add(new []{myList[i],target-t,t});
                        break;
                    }
                    store.Add(t);
                }
            
            
            
                i++;
            }
        
            return result.ToArray();
        }
    }
}