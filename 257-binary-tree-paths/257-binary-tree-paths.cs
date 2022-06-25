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
    public IList<string> BinaryTreePaths(TreeNode root) {
       
       List<string> list=   new List<string>();
          BinaryTree(root, "",list);
       return list;
    }
    public void BinaryTree(TreeNode root ,string s ,List<string> list)
        {
            if (root == null) return;
           if(root.right==null&& root.left == null)
            {
               if(s=="")
                s += root.val;
               else
                s +="->"+ root.val;

                list.Add(s);
            }
          //  s += root.val;
        
              if(s=="")
                s += root.val;
               else
                s +="->"+ root.val;
            //if(root.left!=null)
            BinaryTree(root.left, s, list);
           // if (root.right != null)
                BinaryTree(root.right, s, list);


        }
    
}