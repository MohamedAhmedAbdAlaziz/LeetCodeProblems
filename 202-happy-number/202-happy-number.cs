public class Solution {
    public bool IsHappy(int n) {
         Dictionary<int, int> dic = new Dictionary<int, int>();
            
            while(n!= 1 && !dic.ContainsKey(n))
            {
                dic.Add(n, 0);
                n = Happy(n);
            }
            return n == 1;
    }
     public  int Happy(int n)
        {
            int totalSum = 0;
            while (n > 0)
            {
                int d = n % 10;
                n = n / 10;
                totalSum += d * d;
            }
            return totalSum;
        }
}