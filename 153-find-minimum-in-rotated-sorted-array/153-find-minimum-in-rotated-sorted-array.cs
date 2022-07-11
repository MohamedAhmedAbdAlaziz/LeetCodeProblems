public class Solution {
    public int FindMin(int[] nums) {
        int low=0, high= nums.Length-1;
            while (low<high)
            {
                if(nums[low] < nums[high])
                {
                    return nums[low];
                }

                int mid = low+(high - low) / 2;
                if(nums[mid]>= nums[low])
                {
                    low = mid + 1;

                }
                else
                {
                    high = mid;
                }
           
            }
            return nums[low];
    }
}