public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
            int[] ff = new int[101];
           
            for (int i = 0; i < nums.Length; i++)
            {
                ff[nums[i]]++;          
            }

            for (int i = 1; i < 101; i++)
            {
                ff[i] += ff[i-1];
            }

           
         
            for (int i = 0; i < nums.Length; i++)
            {
                int k = nums[i];
                if (k == 0) nums[i] = 0;
                else
                {
                    nums[i] = ff[k - 1];
                }
            }
            return nums;
    }
}