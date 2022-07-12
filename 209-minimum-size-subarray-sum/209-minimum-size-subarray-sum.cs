public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
             
          int sum = 0;
            int left = 0;
            int right = 0;
            int v = 0;
            int res = nums.Length +1;
           while(v<= nums.Length-1 && right <= nums.Length - 1)
            {
               // if (target == nums[left]) return 1;
                sum += nums[v];               
                 while (sum>=target)
                {
                    res = Math.Min(res, (right - left) + 1);
                    sum -= nums[left];
                     if(sum==target && res== 1) return 1;

                     left++;
                }
                v++;
                right++;
            }
            if (res == nums.Length + 1)
                return 0;
            return res;
    }
}