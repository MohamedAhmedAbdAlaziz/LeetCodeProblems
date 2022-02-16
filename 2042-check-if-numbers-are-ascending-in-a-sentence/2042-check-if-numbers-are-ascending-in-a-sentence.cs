public class Solution {
    public bool AreNumbersAscending(string s) {
         string[] t = s.Split(" ");
 
            int k = Int32.MinValue;  
            for (int i = 0; i < t.Length; i++)
            {
                int y ;
               bool h= Int32.TryParse(t[i].ToString(),out y);
                if (h == true)
                {
                  if(y>k)
                    {
                        k = y;
                    }
                    else
                    {
                        return false;
                    }
                }
              
            }


            return true;
    }
}