public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {
           List<int> newlist = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int k = index[i];
              
                newlist.Insert(k, nums[i]); 

            }

           
            return newlist.ToArray();   
    }
}

