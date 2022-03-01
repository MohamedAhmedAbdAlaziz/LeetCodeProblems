public class Solution {
    public int CountHomogenous(string s) {
        
 Dictionary<int, int> prevSu = new Dictionary<int, int>();
            int m = (int)Math.Pow(10, 9) + 7;

            prevSu[0] = 1;
            int sum = 1;

            for (int i = 1; i < s.Length ; i++)
            {
                prevSu[i] = 1;
                if (s[i] == s[i - 1])
                {
                    prevSu[i] = (prevSu[i] % m + prevSu[i - 1] % m) % m;
                }
                sum = (sum % m + prevSu[i] % m) % m;
               
            }
            return sum;
            
          
    }
}