public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
         var dic = new Dictionary<char, string >();

            for (int i = 0; i < pattern.Length; i++)
            {

                if (dic.ContainsKey(pattern[i]))
                  dic[pattern[i]] = dic[pattern[i]] + "" + i;
                
                else  dic[pattern[i]] =  i+"" ;

                
            }

             var dd22 = dic.Select(x => x.Value).ToList();
           
            List<string> list = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                var dic1 = new Dictionary<char, string>();

                for (int j = 0; j < words[i].Length; j++)
                {
                    if (dic1.ContainsKey(words[i][j]))  dic1[words[i][j]]= dic1[words[i][j]]+"" +j;
                   
                    else  dic1[words[i][j]]= j+"";

                   
                }
                 var tyu2 = dic1.Select(x => x.Value).ToList();
            
                if(tyu2.Count()!= dd22.Count()) continue;
                int k = 0;
                for (k= 0; k <tyu2.Count(); k++)
                {
                    if(tyu2[k] != dd22[k] )  break ;
                  
                    
                }
                if(k==tyu2.Count())
                list.Add(words[i]);


            }
            return list;
    }
}