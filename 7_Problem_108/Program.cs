﻿namespace _7_Problem_108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            TreeNode outputBinaryTree = solution.SortedArrayToBST(new int[] { 0, 1, 2, 3, 4, 5 });
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null, int balfacter = 0)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return BuildTree(nums, 0, nums.Length - 1);
        }

        private TreeNode BuildTree(int[] nums, int left, int right)
        {
            if (left > right)
                return null;

            int mid = left + (right - left) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = BuildTree(nums, left, mid - 1);
            node.right = BuildTree(nums, mid + 1, right);

            return node;
        }

        public TreeNode SortedArrayToBSTx(int[] nums)
        {
            //// [0, 1, 2, 3, 4, 5]
            TreeNode root = new TreeNode();
            if (nums != null && nums.Any())
            {
                int indexMaxOfInput = nums.Length;
                int rootNoteIndex = indexMaxOfInput / 2;
                root = new TreeNode(nums[rootNoteIndex]);

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != root.val)
                    {
                        if (nums[i] < root.val)
                        {
                            LeftRecursiveMethod(nums, root, i);
                        }
                        else
                        {
                            if (nums[i] > root.val)
                            {
                                RightRecursiveMethod(nums, root, i);
                            }
                        }
                    }


                }
            }

            return root;
        }

        private static void RightRecursiveMethod(int[] nums, TreeNode root, int i)
        {
            if (root.right is null)
            {
                root.right = new TreeNode(nums[i]);
            }
            else
            {
                if (root.right != null)
                {
                    if (nums[i] > root.right.val)
                    {
                        if (root.right.right is null)
                        {
                            root.right.right = new TreeNode(nums[i]);
                        }
                        else
                        {
                            RightRecursiveMethod(nums, root.right.right, i);
                        }                        
                    }

                    if (nums[i] < root.right.val)
                    {
                        if (root.right.left is null)
                        {
                            root.right.left = new TreeNode(nums[i]);
                        }
                        else
                        {
                            LeftRecursiveMethod(nums, root.right.left, i);
                        }
                    }
                }
            }
        }

        private static void LeftRecursiveMethod(int[] nums, TreeNode root, int i)
        {
            if (root.left is null)
            {
                root.left = new TreeNode(nums[i]);
            }
            else
            {
                if (root.left != null)
                {
                    if (nums[i] > root.left.val)
                    {
                        if (root.left.right is null)
                        {
                            root.left.right = new TreeNode(nums[i]);
                        }
                        else
                        {
                            RightRecursiveMethod(nums, root.left.right, i);
                        }
                    }

                    if (nums[i] < root.left.val)
                    {
                        if (root.left.left is null)
                        {
                            root.left.left = new TreeNode(nums[i]);
                        }
                        else
                        {
                            LeftRecursiveMethod(nums, root.left.left, i);
                        }
                    }
                }
            }
        }


        private static void CalculateBalanceFactor(TreeNode treeNode)
        {
            
        }
    }
}
