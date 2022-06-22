public class Solution {
    int[] nums ;
  Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();

    public Solution(int[] nums) {
        this.nums= nums;
        
          for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]].Add(i);
                }
                else
                {
                    dic[nums[i]] = new List<int>() { i };
                }

            }
    }
    
    public int Pick(int target) {
    var d=dic[target];
            Random random = new Random();
           int k= random.Next(0, d.Count);

            return d[k];       
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */