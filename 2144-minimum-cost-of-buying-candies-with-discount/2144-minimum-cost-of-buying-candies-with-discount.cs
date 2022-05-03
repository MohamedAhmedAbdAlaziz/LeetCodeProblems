public class Solution {
    public int MinimumCost(int[] cost) {
      
            if (cost.Length == 1) return cost[0];
            if (cost.Length == 2) return cost[0]+ cost[1] ;
        Array.Sort(cost);
        Array.Reverse(cost);

            int sum = 0;
           int i = 0;
            while ( i < cost.Length )
            {
                    if(cost.Length>i+1)
                    sum += cost[i] + cost[i + 1];
                  else
                    sum += cost[i];

                i += 3; 
            }
            return sum;
    }
}