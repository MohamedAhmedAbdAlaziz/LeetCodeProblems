public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        
            StringBuilder ss = new StringBuilder(s);
            int jj = 0;
            for (int i = 0; i < spaces.Length; i++)
            {
                ss.Insert(spaces[i] + jj, ' ');
                jj++;
            }

            return ss.ToString();
    }
}