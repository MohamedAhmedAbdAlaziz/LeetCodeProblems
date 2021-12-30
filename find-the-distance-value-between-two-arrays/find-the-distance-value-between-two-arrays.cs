public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
        
            int k = 0;
            
            for (int i = 0; i < arr1.Length; i++)
            {
                bool ask = true;
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (Math.Abs(arr1[i]-arr2[j]) <= d)
                    {
                        ask = false;
                        break;
                    }
                }
                if (ask == true)
                    k++;
            }
            return k;
    }
}