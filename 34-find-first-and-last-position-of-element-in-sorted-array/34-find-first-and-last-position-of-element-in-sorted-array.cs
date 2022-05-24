public class Solution {
    public int[] SearchRange(int[] nums, int target) {
               int t =    Search(nums, target);
            if (t == -1) return new int[] { -1, -1 };
            int i = t;
            List<int> list = new List<int>();
            while ( i < nums.Length && nums[i] ==target )
             i++;
              list.Add(i-1);

             i = t-1;
            while ( i >=0 && nums[i] ==target )
            i--;
               list.Insert(0, i+1);
            return list.ToArray();
    }
    
      public int Search (int[] nums, int target) {
          int min = 0;
            int max = nums.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if(target== nums[mid])   return mid;
              
                else if(target< nums[mid]) 
                    max = mid - 1;
                 else   min = mid + 1;
                 
            }
            return -1;
    }
}