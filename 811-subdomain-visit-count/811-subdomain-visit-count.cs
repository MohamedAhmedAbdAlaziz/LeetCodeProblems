public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        var dic = new Dictionary<string, int>();
            for (int i = 0; i < cpdomains.Length; i++)
            {
          
                int t2 = Int32.Parse(cpdomains[i].Substring(0,  cpdomains[i].LastIndexOf(" ")));
                string uu = cpdomains[i].Substring( cpdomains[i].LastIndexOf(" ") + 1);
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
              List<string>  list = dic.Select(x => x.Value + " " + x.Key  ).ToList();



            return list;
    }
}