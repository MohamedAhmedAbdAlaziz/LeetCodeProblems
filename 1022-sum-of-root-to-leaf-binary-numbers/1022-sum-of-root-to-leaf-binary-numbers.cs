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
    public int SumRootToLeaf(TreeNode root , int sum =0) {
         if (root == null) return 0;
         sum = (sum << 1) + root.val;
            if (root.left == null && root.right == null) return sum;
              return SumRootToLeaf(root.left, sum) + SumRootToLeaf(root.right, sum);

    }
}