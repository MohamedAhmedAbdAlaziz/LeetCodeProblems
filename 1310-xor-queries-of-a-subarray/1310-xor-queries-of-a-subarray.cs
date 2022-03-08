public class Solution {
    public int[] XorQueries(int[] arr, int[][] queries) {
         int[] newone = new int[arr.Length];

          List<int> newone2 = new List<int>();
            newone[0] = arr[0];
            for (int i = 1; i < newone.Length; i++)
            {
                newone[i] = newone[i - 1]^arr[i] ;
            }

            for (int i = 0; i < queries.Length; i++)
            {
                int L = queries[i][0];
                int R = queries[i][1];
                if (L == 0) newone2.Add(newone[R]);
              else  newone2.Add(newone[R] ^ newone[L-1]);
            }
            return newone2.ToArray();
    }
}