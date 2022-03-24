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
    public IList<double> AverageOfLevels(TreeNode root) {
        
        
        Queue<TreeNode> q = new Queue<TreeNode>();
             int size = 0;
                double sum = 0;
            
            List<double> list = new List<double>();

            q.Enqueue(root);
            
            
            while (q.Count>0)
            { 
                  size = 0;
                  sum = 0;
                Queue<TreeNode> temp = new Queue<TreeNode>();

                while (q.Count!=0)
                {  
                     TreeNode t  = q.Peek();
                         q.Dequeue();
                    sum += t.val;
                    size++;
                if (t.left != null) temp.Enqueue(t.left);
                 if (t.right != null) temp.Enqueue(t.right);
                    
                }
                q = temp;
                list.Add((sum * 1.0 / size));

            }
    return    list;
}
}