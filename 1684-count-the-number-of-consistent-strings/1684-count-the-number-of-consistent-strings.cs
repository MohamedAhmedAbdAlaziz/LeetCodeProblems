public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
              int T = 0;
    

            for (int i = 0; i < words.Length; i++)
            {
                int j=0;
                    string t = words[i];
                for ( j = 0; j < words[i].Length; j++)
                {
                    if (!allowed.Contains(t[j])){
                        break;

                    }
                }
                if (j == words[i].Length) T+=1;
            }
            return T;
    }
}