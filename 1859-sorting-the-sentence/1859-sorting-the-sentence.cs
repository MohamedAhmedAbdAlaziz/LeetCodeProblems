public class Solution {
    public string SortSentence(string s) {
         string[] t = s.Split(" ");
            string u = "";
            Dictionary<int, string> prevSum = new Dictionary<int, string>();

            for (int i = 0; i < t.Length; i++)
            {
                int y =Convert.ToInt32(t[i].Last().ToString());
                prevSum[y] = t[i].Remove(t[i].Length-1);
            }
            for (int i = 1; i <= t.Length; i++)
            {
                if(i!= t.Length)
                {
                    u += prevSum[i] + " ";

                }
                else
                {
                    u += prevSum[i] ;

                }
            }
            return u;
    }
}