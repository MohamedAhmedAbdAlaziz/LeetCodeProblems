public class Solution {
    public bool CheckRecord(string s) {
       if (s.Contains("LLL")) return false;
            int t = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i]=='A')
                t++;
                if (t == 2) return false; 
            }

            return true;   
    }
}