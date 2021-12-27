public class Solution {
    public int MaximumWealth(int[][] accounts) {
     int k = 0;
            for (int i = 0; i < accounts.Length ; i++)
            {
                int t = 0;
                for (int j = 0; j <  accounts[i].Length ; j++)
                {
                    t += accounts[i][j];
                }
                if (t > k)
                {
                    k = t;
                }
            }
            return k;
    }
}