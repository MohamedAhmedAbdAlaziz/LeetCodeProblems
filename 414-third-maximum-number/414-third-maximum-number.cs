public class Solution {
    public int ThirdMax(int[] nums) {
            Stack<int> st = new Stack<int>();
            Array.Sort(nums);
             
            st.Push(nums[nums.Length-1]);
            for (int i = nums.Length-2; i >=0; i--)
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
            return nums[nums.Length-1];
    }
}