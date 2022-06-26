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
  private  int result = 0;
    public int FindTilt(TreeNode root  ) {
            this.result = 0;
            Find(root); 
            return this.result ;
    }
    public int Find(TreeNode root  ) {
             if (root == null) return 0;
             
            int sum1 = Find(root.left);
            int sum2 = Find(root.right);
            int sum3 = Math.Abs(sum1 - sum2);
            this.result += sum3;

            return root.val + sum1 + sum2;
    }
}