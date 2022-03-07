public class Solution {
    public int NumberOfSteps(int num) {
         int t = 0;
        while (num > 0)
        {
            t++;
            if (num % 2 == 0)
            {
                num = num >> 1;
            }
            else
            {
                num = num - 1;
            }

        }
        return t;
    }
}