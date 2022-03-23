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
          List<int> list = new List<int>();
            preorder( root,list );
           return list;
    }
     public void preorder(TreeNode temproot, List<int> list)
        {
            if (temproot != null)
            {
               list.Add(temproot.val );
                preorder(temproot.left,list);
                preorder(temproot.right,list);
            }
        }
}