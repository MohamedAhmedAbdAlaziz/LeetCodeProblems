public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
         Array.Sort(nums);
            int n = nums.Length;
            int res = 0;
            int diff= Int32.MaxValue;
            for (int i = 0; i < n-2; i++)
            {
                int j = i + 1;
                int k = n-1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if(Math.Abs(sum- target)<diff)
                    {
                        res = sum;
                        diff = Math.Abs(sum - target);
                    }
                    if (sum == target) return res;
                    else if (sum > target)
                    {
                        k--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            return res;
    }
}