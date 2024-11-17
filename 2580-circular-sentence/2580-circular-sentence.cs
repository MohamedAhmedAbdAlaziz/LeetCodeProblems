public class Solution {
    public bool IsCircularSentence(string sentence)
{
  if (sentence[0] != sentence[sentence.Length - 1])
  {
      return false;
  }
    string[] strings = sentence.Split(" ");

    for (int i = 1; i < strings.Length; i++)
    {
  
        if (strings[i][0] != strings[i-1][strings[i - 1].Length-1])
        {
            return false;
        }
    }
    return true;
}
}