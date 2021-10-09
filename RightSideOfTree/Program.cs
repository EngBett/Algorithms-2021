using System;
using System.Collections.Generic;
using System.Linq;

namespace RightSideOfTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();
            var queue = new Queue<TreeNode>(new[] {root});

            while (queue.Any())
            {
                TreeNode rightNode = null;
                var queueCount = queue.Count;

                for (var i = 0; i < queueCount; i++)
                {
                    var node = queue.Dequeue();
                    if (node != null)
                    {
                        rightNode = node;
                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);
                    }
                }

                if (rightNode != null)
                    result.Add(rightNode.val);
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    right = new TreeNode(5)
                },
                
                right = new TreeNode(3)
                {
                    right = new TreeNode(5)
                }
            };
            

            var soln = new Solution();

            var res = soln.RightSideView(node);
            foreach (var num in res)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}