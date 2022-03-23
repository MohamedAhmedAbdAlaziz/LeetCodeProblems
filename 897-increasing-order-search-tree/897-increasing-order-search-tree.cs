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
    public TreeNode IncreasingBST(TreeNode root) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
            Queue<int> quue = new Queue<int>();
            TreeNode cur = root;
            List<int> list = new List<int>();

            while (cur != null || stack.Count > 0)
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Pop();
                quue.Enqueue(cur.val);
                cur = cur.right;
            }

             TreeNode newest = new TreeNode(quue.Dequeue());
       
            TreeNode d = newest;
              
            while (quue.Count> 0)
            {
                d.right = new TreeNode(quue.Dequeue());
                d = d.right;
            }

            return newest;
    }
}