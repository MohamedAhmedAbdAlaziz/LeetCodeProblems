public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        int rest = 0;
            int i = num.Length - 1;
            int j = k;
            List<int> list = new List<int>();
            while (j!=0 || i != -1)
            {
                int t1 = 0;
                int t2 = 0;
                if (i >= 0)
                    t1 = num[i];
                if (j > 0)
                    t2 = j % 10;
                int re = t1 + t2 + rest;
                 if (re / 10 == 1)
                {
                    list.Insert(0, (re % 10)) ;

                    rest = re / 10;
                }
                else
                {
                    list.Insert(0, re );

                    rest = 0;
                }
                
                if (i >= 0)
                    i--;
                if (j > 0)
                    j= j/10;


            }
            if (rest > 0)
            {
               list.Insert(0, rest);
            }

            return list;
    }
}