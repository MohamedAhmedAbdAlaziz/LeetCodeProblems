public class Solution {
    public int FindGCD(int[] nums) {
        Array.Sort(nums);
            int b = nums[0];
            int a = nums[nums.Length-1];
             while (b != 0)
            {
                int a2 = a;
                a = b;
                b = a2 % b;
       }
            return a;
    }
}