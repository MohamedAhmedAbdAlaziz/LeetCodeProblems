public class Solution {
    public string LargestTimeFromDigits(int[] arr) {
           Dictionary<int[], int[]> dic = new Dictionary<int[], int[]>();
            dic[new[] { arr[0], arr[1] }] = new[] { arr[2], arr[3] } ;
            dic[new[] { arr[0], arr[2] }] = new[] { arr[1], arr[3] };
            dic[new[] { arr[0], arr[3] }] = new[] { arr[2], arr[1] };
            dic[new[] { arr[1], arr[2] }] = new[] { arr[0], arr[3] };
            dic[new[] { arr[1], arr[3] }] = new[] { arr[0], arr[2] };
            dic[new[] { arr[2], arr[3] }] = new[] { arr[0], arr[1] };

            Dictionary<string, int> dic2 = new Dictionary<string, int>();


            foreach (var item in dic)
            {
                int f = item.Key[0];
                int l = item.Key[1];
                int hh = 0;
                string sh="";
                int k1 =Math.Max( f * 10 + l, l * 10 + f);
                int k2 = Math.Min(f * 10 + l, l * 10 + f);

                if (k1 < 24 && k1 > k2)
                {
                    hh = k1;
                }
                else if (k2 < 24)
                {
                    hh = k2;
                }
                else
                {
                    continue;
                }
                if (hh < 10) sh = "0" + hh;
                else sh = hh.ToString();
                 
               int x = item.Value[0];
                int z = item.Value[1];
                int mm = 0;
                string sm = "";
                int k3 = Math.Max(x * 10 + z, z * 10 + x);
                int k4 = Math.Min(x * 10 + z, z * 10 + x);

                 if (k3 < 60 && k3 > k4)
                {
                    mm = k3;
                }
                else if (k4 < 60)
                {
                    mm= k4;
                }
                else
                {
                    continue;
                }
                if (mm < 10) sm = "0" + mm;
                else sm= mm.ToString();
                string tt = sh + "" + sm;
                if(!dic2.ContainsKey(sh + ":" + sm))
                dic2[sh + ":" + sm] = Convert.ToInt32(tt);
            }
            if (dic2.Count == 0) return "";
            int t = dic2.Max(x => x.Value);
            string ttt = dic2.Where(x => x.Value == t).Select(x => x.Key).FirstOrDefault();
         
            return ttt;    
    }
}