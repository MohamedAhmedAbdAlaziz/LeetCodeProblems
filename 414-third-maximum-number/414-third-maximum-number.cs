public class Solution {
    public int ThirdMax(int[] nums) {
            Stack<int> st = new Stack<int>();
            Array.Sort(nums);
            Array.Reverse(nums);
            st.Push(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                if (st.Peek() != nums[i])
                {
                    st.Push(nums[i]);
                }
                if (st.Count() == 3)
                {
                    return st.Pop();
                }
            }
            return nums[0];
    }
}