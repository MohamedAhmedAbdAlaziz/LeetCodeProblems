public class Solution {
    public bool Find132pattern(int[] nums) {
       int n = nums.Length;
            int[] min = new int[n];
            min[0] = nums[0];
            for (int i = 01; i < n; i++)
            {
                min[i] = Math.Min(min[i - 1], nums[i]);
            }
            Stack<int> stack = new Stack<int>();
            for (int j = n-1; j >=0; j--)
            {
                if(nums[j]> min[j])
                {
                    while (stack.Count() > 0 && stack.Peek() <= min[j])
                        stack.Pop();
                    if (stack.Count() > 0 && stack.Peek() < nums[j])
                        return true;
                    stack.Push(nums[j]);
                }
            }
        return false;
    }
}