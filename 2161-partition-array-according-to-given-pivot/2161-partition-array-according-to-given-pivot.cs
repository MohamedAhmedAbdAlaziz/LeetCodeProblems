public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        List<int> left = new List<int>();
            List<int> rigt = new List<int>();      
        List<int> mid = new List<int>();

          
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < pivot)
                    left.Add(nums[i]);
              else if(nums[i] == pivot)
                  mid.Add(nums[i]);
                else
                    rigt.Add(nums[i]);
             }
        if(mid.Count>0){
            left.AddRange(mid);
           left.AddRange(rigt);}
        else
            left.AddRange(rigt);

            return left.ToArray();
    }
}