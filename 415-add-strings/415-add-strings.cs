public class Solution {
    public string AddStrings(string num1, string num2) {
            int rest = 0;
            int i = num1.Length-1;
            int j = num2.Length-1;
            string result = "";
            while (i>=0 || j>=0)
            {   int t1 = 0;
                int t2 = 0;
                if (i>=0)
               t1=  Convert.ToInt32(num1[i].ToString());
               if(j>=0)
                 t2=  Convert.ToInt32(num2[j].ToString());
                int re = t1 + t2 + rest;
                if(re / 10 == 1)
                {
                     result = (re % 10) + result; 
                     rest = re /10;
                }
                else
                {  result = re + result; 
                  rest = 0;
                }
                  if (i >= 0)
                    i--;
                if (j >= 0)
                    j--;
            }
            if (rest > 0)
            {
                result = rest+ result;
            }
            return result ;
     
    }
}