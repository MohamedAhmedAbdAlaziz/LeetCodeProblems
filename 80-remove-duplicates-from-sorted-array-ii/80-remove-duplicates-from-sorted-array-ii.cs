public class Solution {
    public int RemoveDuplicates(int[] nums) {
             int min = nums[0];
           int slow = 1;
            int t = 1;
            for (int i = 1;  i < nums.Length; i++)
            {
             if(nums[i]!= min)
                {
                    min = nums[i];
                    t = 1;
                    nums[slow++] = min;
                }
             else if(nums[i]== min && t <2)
                {
                    t++;
                   // slow++;
                   nums[slow++] = min;
                }
                
            
            }
             
            return slow;
    }
}