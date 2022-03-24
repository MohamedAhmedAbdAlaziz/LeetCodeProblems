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
    public bool IsUnivalTree(TreeNode root) {
           int k = root.val; 
          Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cur =root;
            

            while(cur!=null || stack.Count > 0)
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Pop();
                if(k !=  cur.val) return false;
               
                cur = cur.right;
            }


            return true;
    }
}