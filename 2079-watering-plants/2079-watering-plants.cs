public class Solution {
    public int WateringPlants(int[] plants, int capacity) {
        int steps = 0;
            int t= 0;
            int k = capacity;
            for (int i = 0; i < plants.Length; i++)
            {
                int m = plants[i];
                k = k - m;
                t++;
                if (i + 1 != plants.Length &&  k < plants[i + 1])
                {
                    steps += t*2;
                    k = capacity;
                }
            }
            steps += t ;

            return steps;
    }
}