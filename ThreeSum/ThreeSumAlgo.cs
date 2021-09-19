using System.Collections.Generic;
using System.Linq;

namespace ThreeSum
{
    public class ThreeSumAlgo
    {
        public static IList<IList<int>> Solution(int[] nums) {
            var myList = nums.ToList();
            var i=0;
            var result = new List<int[]>();
            var visited = new HashSet<int>();
            
            while(i < myList.Count){
                
                if(visited.Contains(myList[i])) continue;

                visited.Add(myList[i]);
                var store = new List<int>();
                var wList = myList.Where((_,index)=>index!=i).ToList();
                var target = 0 - myList[i];
            
                
                foreach (var t in wList)
                {
                    if(store.Contains(target-t)){
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