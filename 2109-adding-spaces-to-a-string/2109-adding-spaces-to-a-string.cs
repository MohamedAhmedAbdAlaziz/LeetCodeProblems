public class Solution {
    public string AddSpaces(string s, int[] spaces) {
          string[] ar = new string[spaces.Length+1];
            ar[0] = s.Substring(0, spaces[0]);

            for (int i = 1; i < spaces.Length; i++)
                ar[i] = s.Substring(spaces[i-1], spaces[i]- spaces[i - 1]);
              

            ar[ar.Length - 1] = s.Substring(spaces[spaces.Length - 1], s.Length - spaces[spaces.Length - 1]);

            return String.Join(" ", ar);
    }
}