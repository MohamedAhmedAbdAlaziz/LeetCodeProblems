public class Solution {
    public int MaxWidthRamp(int[] nums) {
    Stack<int> stack = new Stack<int>();
            int t = 0;
            stack.Push(0);
            for (int i = 0; i < nums.Length; i++)
            {
                
                    if(stack.Count()!=0&& nums[i]< nums[ stack.Peek()])
                    {
                    stack.Push(i);
                    }
                         
                 }
             
                
              while(stack.Count()!= 0)
               {
                for (int i = nums.Length - 1; i >= 0; i--)
                {
                    if (nums[i]>= nums[stack.Peek()])
                    {
                        if(t>i - stack.Peek()){
                            stack.Pop();
                              break;
                        }
                        t = Math.Max(t, i - stack.Pop());
                        break;
                    }
            }

            }

            return t;
    }
}