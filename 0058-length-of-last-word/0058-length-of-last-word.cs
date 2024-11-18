public class Solution {
public  int LengthOfLastWord(string s)
{
     string[] strings = s.Trim().Split(" ");
  return strings[strings.Length - 1].Length;
}
}