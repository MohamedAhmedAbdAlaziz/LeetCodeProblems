public class Solution {
    public int MinFlips(int a, int b, int c) {
           int Count = 0;
            for (int i = 0; i < 32; i++)
            {
                int t = (a % 2);
                int t2 = (b % 2);
                 int y = t | t2;
                int tc = c % 2;
                if (y != tc)
                {
                    Count++;
                   
                    if (t==1 && t2==1)
                    {
                        Count++;

                    }
                }
                
                a = a >> 1;
                b = b >> 1;
                c = c >> 1;
            }
            return Count;
    }
}