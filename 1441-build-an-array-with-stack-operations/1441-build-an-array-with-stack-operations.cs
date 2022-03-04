public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
      
            int k =0;
            List<String> list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if(target.Length  > k && target[k]==i  )
                {
                    list.Add("Push");
                    k++;
                    if (k == target.Length) { break; }
                }
                else
                {
                    list.AddRange(new List<String> { "Push", "Pop" });

                }
            }

            return list;  
    }
}