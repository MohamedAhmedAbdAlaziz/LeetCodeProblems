public class Solution {
    public int FindMaxLength(int[] nums) {
   Dictionary<int, int> prevSum = new Dictionary<int, int>();
        prevSum[0]=-1;
            int y = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count += -1;
                }
                else
                {
                    count++;
                }
                if (prevSum.ContainsKey(count))
                {
                    y = Math.Max(y, i - prevSum[count]);
                }
                else
                {
                    prevSum[count] = i;
                }
            }
            return y;
    }
}
                    
                    
                    
                    
                    
                    
                   
                    
                    
                    
                    
                    
      