public class Solution {
    public bool IsAnagram(string s, string t) {
          char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string s2 = new string(charArray);

            char[] charArray2 = t.ToCharArray();
            Array.Sort(charArray2);
            string s3 = new string(charArray2);

            return s2 == s3;
    }
}