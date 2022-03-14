public class Solution {
    public bool QueryString(string s, int n) {
          int i = 1;
            while(i<=n)
            {
                string t = Convert.ToString(i, 2);
                if (!s.Contains(t)) {
                    return false;
                }
                i++;
            }

            return true;
    }
}