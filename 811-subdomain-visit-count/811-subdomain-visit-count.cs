public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        var dic = new Dictionary<string, int>();
            for (int i = 0; i < cpdomains.Length; i++)
            {


                int tt2 = cpdomains[i].LastIndexOf(" ");
                int t2 = Int32.Parse(cpdomains[i].Substring(0, tt2));
                string uu = cpdomains[i].Substring(tt2 + 1);
                string[] tty  = uu.Split(".");

                string my = "";

                for (int j = tty.Length-1; j>=0; j--)
                {
                    if(my!= "")
                    my  =  tty[j]+"."+my;
                    else
                     my =  tty[j];


                 
                if (dic.ContainsKey(my))
                    {
                        
                        dic[my] += t2;
                    }
                    else
                    {
                         dic[my] = t2;

                    }
                }
            }
            List<string> list = new List<string>();

            foreach (var item in dic)
            {
                list.Add(item.Value + " " + item.Key);
            }


            return list;
    }
}