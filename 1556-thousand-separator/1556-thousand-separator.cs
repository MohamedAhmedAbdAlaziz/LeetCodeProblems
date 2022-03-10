public class Solution {
    public string ThousandSeparator(int n) {
        string s = n.ToString();
            string st = "";
            int t = 0;
            for (int i = s.Length-1; i >=0 ; i--)
            {
                if(t==3)
                {
                    st = s[i] +"."+ st;
                    t = 1;
                }
                else
                {
                    st = s[i] + st;
                    t++;
                }

            }
            return st;
    }
}