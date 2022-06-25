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
    public bool FindTarget(TreeNode root, int k) {
      Dictionary<int, int> t = new Dictionary<int, int>();

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cur = root;
            List<int> list = new List<int>();

            while (stack.Count > 0 || cur != null)
            {

                while (cur != null)
                {
                    if (t.ContainsKey(k- cur.val))
                    {
                        return true;
                    }
                    else
                    {
                        t[cur.val] = 1;
                    }
                       
                    stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Pop();

                cur = cur.right;
            }

            return false;   
    }
}