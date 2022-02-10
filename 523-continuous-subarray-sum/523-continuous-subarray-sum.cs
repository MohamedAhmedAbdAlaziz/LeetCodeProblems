public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
   int sum = 0;
    var map = new Dictionary<int, int>();
    map[0] = -1;
    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
        if (k != 0)
            sum = sum % k;
        if (map.ContainsKey(sum) && i - map[sum] >= 2) return true;
        map[sum] = map.ContainsKey(sum) ? map[sum] : i;
    }
    return false;}
}