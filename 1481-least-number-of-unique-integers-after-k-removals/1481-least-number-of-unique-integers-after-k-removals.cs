public class Solution {
    public int FindLeastNumOfUniqueInts(int[] arr, int k) {
       
                var dic1 = new Dictionary<int, int>();
           
            for (int i = 0; i < arr.Length; i++)
            {
                if (dic1.ContainsKey(arr[i]))  dic1[arr[i]] += 1; 
             
                else  dic1[arr[i]] = 1;

                
            }

       
            var rr = dic1.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int t = 0;
            foreach (var item in rr)
            {
                int gg = item.Key;
                int yy = rr[gg];
                if (k < yy) return rr.Skip(t).Count();
                else if (k==yy) return rr.Skip(t+1).Count();
                else
                {
                    k = k - yy;
                    t++;
                }
              
                

            }

            return rr.Skip(t).Count();
           
    }
}