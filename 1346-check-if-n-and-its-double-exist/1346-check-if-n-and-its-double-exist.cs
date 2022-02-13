public class Solution {
    public bool CheckIfExist(int[] arr) {
         Array.Sort(arr);
            Dictionary<int, int> prevSum = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (prevSum.ContainsKey(arr[i]))
                    { 
                    return true;
                   }
                else{
                    if (arr[i] < 0 && arr[i] %2==0)
                    {
                        int t = arr[i] /2;
                        prevSum[t] = 0;
                    }
                    else
                    {
                        int t = arr[i] * 2;
                        prevSum[t] = 0;
                    }


                }
            }
            return false; 
    }
}