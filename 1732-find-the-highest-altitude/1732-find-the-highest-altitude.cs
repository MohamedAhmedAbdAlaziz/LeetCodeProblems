public class Solution {
    public int LargestAltitude(int[] gain) {
       List<int> li = new List<int>();
           li.Add(0);
            int k = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                k += gain[i];
                li.Add(k);
            }
            return li.Max();  
    }
}