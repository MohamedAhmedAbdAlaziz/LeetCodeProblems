public class Solution {
    public int[] RearrangeArray(int[] nums) {
         int n1 = nums.Length / 2;

              int[] Arrav = new int[n1];
            int[] Arrat = new int[n1];
            int m1 = 0;
            int m2 = 0;
            for (int i = 0; i <  nums.Length; i++)
            {
                if (nums[i] > 0)
                {  
                Arrat[m1] = nums[i];
                    m1++;
            }
                else
                {
                    Arrav[m2] = nums[i];
                    m2++;
                }
        }
               m1 = 0;
              m2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (i % 2 == 0)
                {
                    nums[i] = Arrat[m1];
                    m1++;

                }
                else
                {
                    nums[i] = Arrav[m2];
                    m2++;

                }
            }
            return nums;
    }
}