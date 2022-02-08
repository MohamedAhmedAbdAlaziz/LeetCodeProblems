public class Solution {
    public int FindMiddleIndex(int[] nums) {
          int t = 0;
            int[] first = new int[nums.Length];
            int[] second = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                t += nums[i];
                first[i] = t;
            }
            t = 0;
           for (int i = nums.Length-1; i >=0; i--) 
            {
                t += nums[i];
                second[i] = t;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (first[i] == second[i])
                    return i;
            }
            return -1;   
    }
}