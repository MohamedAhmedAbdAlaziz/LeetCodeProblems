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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
         Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cur = root1;
            List<int> list = new List<int>();

            while (stack.Count > 0 || cur != null)
            {

                while (cur != null)
                {
                if (cur.left == null&& cur.right== null)
                        list.Add(cur.val);
                    stack.Push(cur);
                    cur = cur.left;
                    

                }
                cur = stack.Pop();
             
                cur = cur.right;
            }
       stack = new Stack<TreeNode>();
              cur = root2;
            List<int> list2 = new List<int>();

            while (stack.Count > 0 || cur != null)
            {

                while (cur != null)
                {
                if (cur.left == null&& cur.right== null)
                        list2.Add(cur.val);
                    stack.Push(cur);
                    cur = cur.left;
                    

                }
                cur = stack.Pop();
             
                cur = cur.right;
            }
        
          if (list.Count != list2.Count) return false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != list2[i]) return false;
            }
            return true;

        

               
    }
}