public class Solution {
    public bool CanConstruct(string s, int k) {
        if(s.Length< k) return false;
            char[] arr = new char[26];
            for (int i = 0; i < s.Length; i++)
            {
                arr[s[i] - 'a']++;
            }
            int km = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0) km++;
            }
            return km <= k;
    }
}