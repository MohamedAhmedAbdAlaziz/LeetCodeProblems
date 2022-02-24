public class Solution {
    public int[] Decrypt(int[] code, int k) {
            if (k > 0)
            {
     int[] newA = new int[code.Length];

                int t = 0;
                for (int i = 0; i < code.Length; i++)
                {
                    t = i + 1;
                    int h =0;
                    while(h!= k)
                    {
                        if (t == code.Length)
                            t = 0;
                        newA[i] += code[t];
                        h++;
                        t++;
                    }
                }
                return newA;
            }
            else if (k < 0)
            {
             int[] newA = new int[code.Length];

                int t = 0;
                for (int i = 0; i < code.Length; i++)
                {
                    t = i -1;
                    int h = 0;
                    while (h != k)
                    {
                        if (t == -1)
                            t = code.Length-1;
                        newA[i] += code[t];
                        h--;
                        t--;
                    }
                }
                return newA;
            }

            return new int[code.Length];
    }
}