public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
          Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] =
                    dic[nums[i]] + 1;
                }
                else
                {
                    dic[nums[i]] = 1;
                }
            }

       return dic.OrderByDescending(x=>x.Value).Select(x => x.Key).Take(k).ToArray();
     
       
    }
}