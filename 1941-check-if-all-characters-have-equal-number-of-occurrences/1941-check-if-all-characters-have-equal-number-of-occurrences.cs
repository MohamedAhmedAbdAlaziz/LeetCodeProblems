public class Solution {
    public bool AreOccurrencesEqual(string s) {
           Dictionary<char, int> prevSum = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (prevSum.ContainsKey(s[i]))
                {
                    prevSum[s[i]] = 1 + prevSum[s[i]];
                }
                else
                {
                    prevSum[s[i]] = 1;
                }
            }
            var t = prevSum.Select(x => x.Value).ToArray();

            for (int i = 0; i < t.Length-1; i++)
            {
                if (t[i] != t[i+1])
                {
                    return false;
                }
            }
            return true;
    }
}