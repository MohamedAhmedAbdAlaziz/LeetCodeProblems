public class Solution {
    public int[] FinalPrices(int[] prices) {
          Stack<int> st = new Stack<int>();
          for (int i = 0; i < prices.Length; i++)
            {  while(st.Count>0 && prices[st.Peek()]>=prices[i])
                    prices[st.Pop()] -= prices[i]; 
               st.Push(i);
            }
            return prices;
    }
}