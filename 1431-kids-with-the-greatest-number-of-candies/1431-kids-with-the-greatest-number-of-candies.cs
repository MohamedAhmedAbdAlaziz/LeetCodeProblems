public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
         int k = 0;
            for (int i = 0; i < candies.Length; i++)
            {
                k = Math.Max(candies[i],k);
            }
            bool[] kids = new bool[candies.Length]; 
            for (int i = 0; i < candies.Length; i++)
            {
                int m = candies[i] + extraCandies;
                if(m>= k)
                {
                    kids[i] = true;
                }
                else
                {
                    kids[i] = false;
                }
            }

            return kids;
        
    }
}