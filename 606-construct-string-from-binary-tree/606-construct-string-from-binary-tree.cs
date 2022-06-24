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
    public string Tree2str(TreeNode root) {
            return  dfs(root);
    }
        public String dfs(TreeNode root)
        {
            if (root == null)
                return "";
            if (root.right != null)
                return root.val + "(" + dfs(root.left)+")(" + dfs(root.right)+")";
              if (root.left != null)
                return root.val + "(" + dfs(root.left)+")";
            return root.val + "";
            
            
        }
}