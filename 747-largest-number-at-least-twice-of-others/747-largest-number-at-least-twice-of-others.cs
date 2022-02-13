public class Solution {
    public int DominantIndex(int[] nums) {
            if (nums.Length == 1) return 0;
        Dictionary<int, int> prevSum = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {

                prevSum[nums[i]] = i;
            }
            Array.Sort(nums);

       if(nums[nums.Length-1]>= (nums[nums.Length - 2]*2))
            {
                return prevSum[nums[nums.Length - 1]];
            }
            

            return -1;
    }
}