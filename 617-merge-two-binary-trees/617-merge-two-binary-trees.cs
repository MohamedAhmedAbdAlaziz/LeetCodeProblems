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
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        if (root1 == null && root2 == null) 
            return null;
          if (root1 == null && root2 != null) 
            return root2;
          if (root1 != null && root2 == null) 
                        return root1;


            int v1 = root1 != null ? root1.val : 0;
            int v2 = root2 != null ? root2.val : 0;
            TreeNode r = new TreeNode(v1 + v2);
            r.left = MergeTrees(root1.left != null ? root1.left : null, root2.left != null ? root2.left : null);
            r.right = MergeTrees(root1.right != null ? root1.right : null, root2.right != null ? root2.right : null);

           return r;
    }
}