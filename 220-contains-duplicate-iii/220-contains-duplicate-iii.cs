public class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
           for (int i = 0; i < nums.Length; i++)
            {
                int j = i+1;
                while (j<i+k+1  && j <nums.Length)
                {
                      //  int mt = 1;

                        if (Math.Abs((double)nums[j] - (double)nums[i]) <= t)
                    {
                        return true;
                    }
                 //   mt++;
                    j++;
                }
            }
            return false;
    }
}