public class Solution {
    public int NumOfPairs(string[] nums, string target) {
        int t = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int j = 0;
                while ( j < nums.Length )
                {
                   
                    if (i != j && nums[i] + nums[j] == target) t += 1;
                j++;
            }
                 
            }
            return t;
    }
}