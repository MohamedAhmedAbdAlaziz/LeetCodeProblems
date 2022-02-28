public class Solution {
    public int SingleNumber(int[] nums) {
                     int p = 0;  
              int q = 0;  
           for(int i = 0; i<nums.Length; i++){  
              p = q & (p ^ nums[i]);  
              q = p | (q ^ nums[i]);  
           }  
           return q; 
       
    }
}