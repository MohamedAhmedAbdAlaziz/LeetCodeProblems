public class Solution {
    public string ReversePrefix(string word, char ch) {
        int t = word.IndexOf(ch);
            string s = word.Substring(0, t+1);
            string s1 = "";
            for (int i= s.Length-1; i>=0 ; i--)
            {
                s1 += s[i];
            }
           return s1 += word.Substring(t+1);
    }
}