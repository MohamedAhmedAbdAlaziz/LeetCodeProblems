public class Solution {
    public int MinSetSize(int[] arr) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]] += 1;
                }
                else
                {
                    dic[arr[i]] = 1;

                }
            }
            var ineArray = dic.Select(x => x.Value).ToArray();
            Array.Sort(ineArray);
         
            int min = 1;
            int yy = 0;
            for (int i = ineArray.Length-1; i >=0; i--)
            {
                 yy += ineArray[i];
                if (yy >= arr.Length / 2)
                    return min;
                min++;
            }
            return min;
    }
}