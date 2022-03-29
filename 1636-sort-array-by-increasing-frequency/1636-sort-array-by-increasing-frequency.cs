public class Solution {
    public int[] FrequencySort(int[] nums) {
          Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    dic[nums[i]] = dic[nums[i]] + 1;
                else
                    dic[nums[i]] = 1;

            }
           
             var g=   dic.OrderBy(x => x.Value).ThenByDescending(x=>x.Key);

            int im = 0;
            foreach (var item in g)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    nums[im] = item.Key;
                    im++;
                }
            }
            return nums;
    }
}