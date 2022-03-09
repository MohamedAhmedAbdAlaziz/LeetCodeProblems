public class Solution {
    public int MinFlips(int a, int b, int c) {
           int Count = 0;
            for (int i = 0; i < 32; i++)
            { 
                int y = (a % 2) | (b % 2);
                int tc = c % 2;
                if (y != tc)
                {  
                    Count++; 
                    if ((a % 2) == 1 && (b % 2) == 1)
                        Count++;      
                }

                a = a >> 1;
                b = b >> 1;
                c = c >> 1;
            }
            return Count;
    }
}