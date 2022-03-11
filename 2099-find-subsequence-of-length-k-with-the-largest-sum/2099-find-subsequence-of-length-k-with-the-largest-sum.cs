public class Solution {
    public int[] MaxSubsequence(int[] nums, int k) {
       List<int> dic = new List<int>();
            
            for (int i = 0; i < k; i++)
            {
                dic.Add(nums[i]);
            }

            for (int i = k; i < nums.Length; i++)
            {
                int t =dic.IndexOf( dic.Min());
                if (nums[i]> dic[t])
                {
                    dic.Add(nums[i]);
                    dic.RemoveAt(t);
                }
            }
            
            return dic.ToArray();
    }
}