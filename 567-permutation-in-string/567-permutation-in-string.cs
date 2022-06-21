public class Solution {
    public bool CheckInclusion(string s1, string s2) {
         int[] arr1 = new int[26];

            for (int j = 0; j < s1.Length; j++)
            {
                arr1[s1[j] - 'a']++;
            }
            string s11 = string.Join("", arr1);
            for (int i = 0; i < s2.Length - s1.Length + 1; i++)
            {
                string s13 = s2.Substring(i, s1.Length);
                int[] arr = new int[26];
                for (int j = 0; j < s1.Length; j++)
                {
                    arr[s13[j] - 'a']++;
                }
                string ss = string.Join("", arr);
                if (ss == s11) return true;

            }
            return false;
    }
}