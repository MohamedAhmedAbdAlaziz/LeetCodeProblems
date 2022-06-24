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
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> list = new List<int>();
            inorder( root,list );
           return list;
    }
      public void inorder(TreeNode root, List<int> list )
        {
            if (root != null)
            {

                inorder(root.left,list);
                inorder(root.right,list);
                list.Add(root.val);

            }
        }
    
}