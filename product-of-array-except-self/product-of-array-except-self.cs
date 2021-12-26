public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
           int k = 1, l = 1;
            int[] num1 = new int[nums.Length+1];
            int[] num2 = new int[nums.Length+1];
            for (int i = 0; i < nums.Length; i++)
            {
                    k *= nums[i];
                    l *= nums[nums.Length -1- i];
                    num1[i+1] = k;
                    num2[nums.Length - 1 - i] = l;
                 }
            num1[0] = 1;
            num2[num2.Length-1] = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = num1[i]* num2[i+1];
            }

            return nums; 
    }
}