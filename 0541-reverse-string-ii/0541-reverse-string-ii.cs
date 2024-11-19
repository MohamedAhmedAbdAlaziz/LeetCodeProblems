public class Solution {
 public string ReverseStr(string s, int k)
{
char[] chars = s.ToCharArray();
for (int i = 0; i < chars.Length; i += 2 * k)
{
    int start = i;
    int j = Math.Min(start + k - 1, chars.Length - 1);
    while (start < j)
    {
        char tmp = chars[start];
        chars[start++] = chars[j];
        chars[j--] = tmp;
    }

}
return new String(chars);    

}

}
