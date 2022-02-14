public class Solution {
    public string KthDistinct(string[] arr, int k) {
         Dictionary<string, int> prevSum = new Dictionary<string, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (prevSum.ContainsKey(arr[i]))
                {
                    
                    prevSum[arr[i]] = prevSum[arr[i]] + 1;
                }
                else
                {
                    prevSum[arr[i]] = 1;

                }
            }
            int t = 1;
            foreach (var item in prevSum)
            {
                if(item.Value==1)
                {
                    if (t == k)
                        return item.Key;
                    t++;
                }
            }
            return "";
    }
}