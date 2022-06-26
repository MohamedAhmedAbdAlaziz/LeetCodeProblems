/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */ 
public class Solution {
          public int GetMinimumDifference(TreeNode root)
        {  List<int> list = new List<int>();
            inorder(root, list);
            //return list;
            list.Sort();
            int km = int.MaxValue;
            for (int i = 1; i < list.Count; i++)
            {
                km = Math.Min(km, list[i] - list[i - 1]);
            }
            return km;
        }

        public void inorder(TreeNode root, List<int> list)
        {
            if (root != null)
            {
                inorder(root.left, list);
                list.Add(root.val);
                inorder(root.right, list);
            }
        }

}