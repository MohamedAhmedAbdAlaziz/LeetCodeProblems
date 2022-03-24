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
    public int SumOfLeftLeaves(TreeNode root) {
      Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cur = root;
            
            int sum = 0;
            while (stack.Count > 0 || cur != null)
            {

                while (cur != null)
                {
                    stack.Push(cur);
                 cur = cur.left;
                if(cur != null &&cur.left == null && cur.right == null   )
                    sum+=cur.val;

                }
                cur = stack.Pop();
             
                cur = cur.right;
            }

            return sum;

        }
}