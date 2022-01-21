public class Solution {
    public int HeightChecker(int[] heights) {
            int[] newarr = (int[])heights.Clone();

            Array.Sort(heights);

            int k = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (newarr[i] != heights[i])
                    k++;
            }
            return k;

    
    }
}