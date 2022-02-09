public class Solution {
    public int SubarraySum(int[] nums, int k) {
      
            Dictionary<int, int> prevSum = new Dictionary<int, int>();

            int res = 0;

            // Sum of elements so far
            int currsum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currsum += nums[i];

                if (currsum == k)
                    res++;
                if (prevSum.ContainsKey(currsum - k))
                    res += prevSum[currsum - k];

                if (!prevSum.ContainsKey(currsum))
                {
                    prevSum.Add(currsum, 1);

                }
                else
                {
                  int count = prevSum[currsum];
                    prevSum[currsum] = count + 1;
                }


            }
            return res;
    }
}