using System.Collections.Generic;
using NUnit.Framework;
using ThreeSum;

namespace Tests
{
    public class ThreeSumTest
    {
        [Test]
        public void Test1()
        {
            var nums = new[] {-1, 0, 1, 2, -1, -4};
            var expected = new List<int[]>()
            {
                new []{-1,-1,2},
                new []{-1,0,1}
            };
            var result = ThreeSumAlgo.Solution(nums);
            
            Assert.AreEqual(expected,result);
        }
    }
}