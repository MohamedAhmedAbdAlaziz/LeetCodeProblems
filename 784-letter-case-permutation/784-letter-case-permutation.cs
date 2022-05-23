public class Solution {
    public IList<string> LetterCasePermutation(string s) {
         if (s.Length == 0)
            {
                return new List<string>();
            }
            char t = s[0];
            string t2 = s.Substring(1);
          IList<string> newList=LetterCasePermutation(t2);
            IList<string> prem= new List<string>();
            int y = 0;
           bool y2= Int32.TryParse(t.ToString(),out y);
            if (!y2)
            {
                prem = new List<string>()
                {
                 t.ToString().ToLower(),
                 t.ToString().ToUpper()
                };
            }
            else
            {
                prem = new List<string>()
                {
                 t.ToString()
                };
            }

          
            if (newList.Count()== 0) return prem;
            IList<string> prem3 = new List<string>();

            for (int i = 0; i < prem.Count(); i++)
            {
                IList<string> prem2 = new List<string>(newList);

                for (int j   = 0; j < prem2.Count(); j++)
                {
                    prem3.Add( prem[i] + prem2[j]);
                }
               
            }

            return prem3;
    }
}