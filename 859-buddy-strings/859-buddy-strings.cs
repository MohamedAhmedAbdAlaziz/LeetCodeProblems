public class Solution {
    public bool BuddyStrings(string s, string goal) {
     
       if (s.Length != goal.Length) return false;


            Dictionary<char, int> prevSum = new Dictionary<char, int>();
       List<string> list = new List<string>();
            if (s == goal)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (prevSum.ContainsKey(s[i])) return true;
                    prevSum.Add(s[i],i);
                }
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                     if(s[i] != goal[i])
                    {
                     list.Add(s[i].ToString());
                        list.Add(goal[i].ToString());
                    }
                }
             if (list.Count() == 4 && list[2] + list[0] == list[1] + list[3]) return true;
            }
            return false;
    }
}