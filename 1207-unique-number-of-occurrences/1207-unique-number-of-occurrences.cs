public class Solution {
    public bool UniqueOccurrences(int[] arr) {
 Dictionary<int, int> prevSum = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (prevSum.ContainsKey(arr[i]))
                {
                    prevSum[arr[i]] = 1 + prevSum[arr[i]];
                }
                else
                {

                    prevSum.Add(arr[i], 1);
                }
            }
            var t = prevSum.Select(x => x.Value).OrderBy(x => x).ToArray();


            for (int i = 0; i < t.Length-1; i++)
            {
                if (t[i] == t[i + 1])
                {
                    return false;
                }
            }
            return true;
    }
}