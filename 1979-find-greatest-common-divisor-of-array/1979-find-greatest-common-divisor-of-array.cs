public class Solution {
    public int FindGCD(int[] nums) {
          int b = nums.Min();
            int a = nums.Max();

            while (b != 0)
            {
                int a2 = a;
                a = b;
                b = a2 % b;
       }
            return a;
    }
}