public class Solution {
    public int XorOperation(int n, int start) {
        int t2 = 0;
          for (int i = 0; i < n; i++) t2 ^= start + 2 * i;
            
            return t2;
    }
}