public class Solution {
    public void Rotate(int[] nums, int k) {
      k = k % nums.Length;
            if (k == 0) return;
            
            int[] list = new int[nums.Length];
            int b = 0;
            for (int i = nums.Length - k; i < nums.Length; i++)
            {
                list[b]=nums[i];
                b++;
            }
            for (int i = 0; i < nums.Length - k; i++)
            {
                list[b] = nums[i];
                b++;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = list[i];
            }

    }
}