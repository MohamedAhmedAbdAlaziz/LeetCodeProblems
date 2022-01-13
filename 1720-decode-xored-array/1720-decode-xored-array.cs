public class Solution {
    public int[] Decode(int[] encoded, int first) {
          int[] h = new int[encoded.Length + 1];
            h[0] = first;
            int k = first;
            for (int i = 0; i < encoded.Length; i++)
            {

                k ^= encoded[i];
                h[i + 1] = k;
            }
            return h;
    }
}