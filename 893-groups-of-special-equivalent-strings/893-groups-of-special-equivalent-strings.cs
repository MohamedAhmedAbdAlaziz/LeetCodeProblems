public class Solution {
    public int NumSpecialEquivGroups(string[] words) {
        HashSet<string> list = new HashSet<string>();
            foreach (var item in words)
            {

            
                int[] odd = new int[26];
                int[] even = new int[26];
                for (int j = 0; j < item.Length; j++)
                {
                    if(j% 2 == 0)
                    {
                        even[item[j] - 'a']++;
                    }
                    else
                    {
                        odd[item[j] - 'a']++;

                    }
                }
                string ss = string.Join("", odd) + string.Join("", even);
                list.Add(ss);
            }
            return list.Count();
    }
}