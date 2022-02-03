public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) {
          Dictionary<int, int> myDic = new Dictionary<int, int>();
            int count = 0;
            foreach (var num1 in nums1)
            {
                foreach (var num2 in nums2)
                {
                    int temp = num1 + num2;

                    myDic.TryAdd(temp, 0);
                    myDic[temp]++;

                }
            } 
            foreach (var num3 in nums3)
            {
                foreach (var num4 in nums4)
                {
                    int temp = num3 + num4;
                    if (myDic.ContainsKey(-temp))
                    {
                        count += myDic[-temp];

                    }
                 

                }
            }
            return count;

         
    }
}