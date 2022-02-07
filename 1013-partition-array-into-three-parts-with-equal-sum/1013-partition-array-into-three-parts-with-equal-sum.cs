public class Solution {
    public bool CanThreePartsEqualSum(int[] arr) {
           
          
            int t = arr.Sum();
            if (t % 3 != 0)
                return false;
            t /= 3;
            
            int temp = 0;
            int part=0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp += arr[i];
                if (temp == t)
                {
                    temp = 0;
                    part++;
                }
                if (part == 3) return true;
            }
            return false;
    }
}