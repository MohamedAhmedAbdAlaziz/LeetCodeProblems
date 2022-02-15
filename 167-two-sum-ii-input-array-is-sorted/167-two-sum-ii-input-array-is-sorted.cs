public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
          List<int> list = new List<int>();
            Dictionary<int, int> prevSum = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (prevSum.ContainsKey(target - numbers[i]))
                {
                  
                    list.Add(prevSum[target - numbers[i]] + 1);
                    list.Add(i + 1);
                    return list.ToArray();
                }
                else
                {
                    prevSum[numbers[i]] = i;
                }
            }
            return new int[] { };
    }
}