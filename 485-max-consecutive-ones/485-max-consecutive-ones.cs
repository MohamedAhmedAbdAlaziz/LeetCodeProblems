public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
           int c = 0;           int k= 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    k++;
                }
                else
                {
                    c = Math.Max(c, k);
                    k = 0;
                }
            
                }
              
           
            c = Math.Max(c, k);
            return c;
    }
}