public class Solution {
    public int Search(int[] nums, int target) {
             int left = 0;
            int right = nums.Length-1;
            while (left<= right)
            {
                
                int middle = left + ((right- left)/ 2);
                if(target == nums[middle]) return middle;
                else if(nums[middle] > nums[left])
                {
                    if ( nums[left] <= target && target < nums[middle])
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }

                 else if(nums[middle] < nums[right])
                {
                    if (nums[middle] < target && target <= nums[right])
                    {
                        left = middle + 1;
                    }
                    else
                    {
                        right = middle - 1;
                    }
                }
                else
                {
                    if (nums[left] == nums[middle]) left++;
                    if (nums[right] == nums[middle]) right--;
                }
               
                    

            }
            return -1;
    }
}