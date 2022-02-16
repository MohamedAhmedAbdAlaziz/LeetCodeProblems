public class Solution {
    public string SortSentence(string s) {
               string[] t = s.Split(" ");
            string[] newstring = new string[t.Length];
             for (int i = 0; i < t.Length; i++)
            {
                int y =Convert.ToInt32(t[i].Last().ToString());
              
                newstring[y - 1] = t[i].Remove(t[i].Length - 1);
            }
         
            return String.Join(" ", newstring) ;
    }
}