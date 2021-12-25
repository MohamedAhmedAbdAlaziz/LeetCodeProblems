public class Solution {
    public string RestoreString(string s, int[] indices) {
         string[] k = new string[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                
                k[indices[i]] = s[i].ToString();
            }
          
            return string.Join("", k);
    }
}