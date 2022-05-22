public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
         var d = new Dictionary<int, int>();
            List<int> t = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (d.ContainsKey(nums[i]))
                {
                    if(d[nums[i]] == 1)
                       t.Add(nums[i]);
                    d[nums[i]] += 1;
                }   
                else   d[nums[i]] = 1;
               
            }
            return t;
    }
}