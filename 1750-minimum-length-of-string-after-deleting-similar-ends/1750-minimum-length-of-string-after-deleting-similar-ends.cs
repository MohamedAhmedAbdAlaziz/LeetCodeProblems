public class Solution {
    public int MinimumLength(string s) {
        int k = 0;
            int l = s.Length-1;
          
            while ( s[l] == s[k] && k< s.Length && l>=0 && l>k)
            {
                if (l - k == 1 || l == k) return 0;

               while (l > k && s[k] == s[k + 1] ) k++;
                while (l > k && s[l] == s[l - 1] ) l--;
                if (l - k == 1 || l==k) return 0;

                k++;
                l--;


            }
            return l-k+1;
    }
}