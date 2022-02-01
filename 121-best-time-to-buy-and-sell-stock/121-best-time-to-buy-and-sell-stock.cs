public class Solution {
    public int MaxProfit(int[] prices)
    {
            int x = prices[0];
            int max1 = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > x)
                {
                    max1 = Math.Max(max1, prices[i] - x);


                }
                else
                {
                    x = prices[i];
                }


            }
            return max1;
    }
}