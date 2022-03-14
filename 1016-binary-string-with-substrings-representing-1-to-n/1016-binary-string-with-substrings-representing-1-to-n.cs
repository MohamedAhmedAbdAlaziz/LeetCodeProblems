public class Solution {
    public bool QueryString(string s, int n) {
          int i = 1;
            while(i<=n)
            {
            
                if (!s.Contains(Convert.ToString(i, 2))) {
                    return false;
                }
                i++;
            }

            return true;
    }
}