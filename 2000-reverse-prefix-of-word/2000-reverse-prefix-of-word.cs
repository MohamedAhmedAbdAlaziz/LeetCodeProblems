public class Solution {
    public string ReversePrefix(string word, char ch) {
        int t = word.IndexOf(ch);
            char[] s = word.Substring(0, t+1).ToCharArray();
                Array.Reverse(s);
             return  string.Join("",s)+ word.Substring(t+1);
             
    }
}