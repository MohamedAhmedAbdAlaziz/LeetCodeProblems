public class Solution {
    public string FirstPalindrome(string[] words) {
       
        for (int i = 0; i < words.Length; i++)
            {
                string k = words[i];
                int h = 0 ;
                int n = k.Length;
                for (int j = 0; j <n/2 ; j++)
                {
                    if (k[j] == k[n - j - 1])  h++;
                    else break;              
                    
                 
                }
                if (h == words[i].Length / 2)
                   return words[i] ;


            }
            return "";

    }
}