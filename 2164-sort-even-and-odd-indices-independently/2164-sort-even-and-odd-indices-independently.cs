public class Solution {
    public int[] SortEvenOdd(int[] nums) {
          int t = nums.Length ;
            int n1 = 0;
            int n2 = 0;
            if (nums.Length % 2 == 0)
            {
                n1 = t / 2; 
                n2 = t / 2; 
            }
            else
            {
                n1 = (t / 2)+1;
                n2 = t / 2;
            }
            int[] Arrat = new int[n1];
            int m = 0;
            for (int i = 0; i < t; i+=2)
            {
                Arrat[m] = nums[i];
                m++;
            }
            Array.Sort(Arrat);
            

            int[] Arrav = new int[n2];
            m = 0;
            for (int i = 1; i < t; i += 2)
            {
                Arrav[m] = nums[i];
                m++;
            }
            Array.Sort(Arrav);
            Array.Reverse(Arrav);
            int mm = 0;
            int mm2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (i % 2 == 0)
                {
                    nums[i] = Arrat[mm];
                    mm++;

                }
                else
                {
                    nums[i] = Arrav[mm2];
                    mm2++;

                }
            }
            return nums;
    }
}