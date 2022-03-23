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
    public IList<int> PreorderTraversal(TreeNode root) {
         
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cur = root;
            List<int> list = new List<int>();
               
            while (stack.Count > 0 || cur!= null)
            {
               
                while (cur != null)
                {
                    list.Add(cur.val);
                     stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Pop();
                
                cur = cur.right;
            }

            return list;
    }
    
}