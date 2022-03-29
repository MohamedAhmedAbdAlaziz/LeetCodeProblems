public class Solution {
    
    public bool DivideArray(int[] nums) {
                 Dictionary<int,int> dic = new Dictionary<int,int>();
             
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    dic[nums[i]] = dic[nums[i]] + 1;
                else
                    dic[nums[i]] =  1;

            }
            foreach (var item in dic)
            {
                if (item.Value % 2 != 0)
                    return false;
            }
            return true;
    }
}