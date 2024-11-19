public class Solution {
    public bool IsPalindrome(string s) {
      s = s.Replace(" ", "").ToLower();
 int i=0;
 int j=s.Length-1;
 int k = 0;
 string dic = "abcdefghijklmnopqrstuvwxyz0123456789";
 while (i<j )
 {
     
     while(i<j&& !dic.Contains(s[i])) {
          
         Console.WriteLine(s[i]);
         i++;
     }
     while(i < j && !dic.Contains(s[j])) {
         Console.WriteLine(+s[j]);

         j--;
     }
     if (s[i] != s[j])
     {
         return false;
     }
    


     i++;
     j--;
 }
 return true ;
    }
}