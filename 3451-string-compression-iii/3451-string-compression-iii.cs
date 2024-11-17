public class Solution {
    public   string CompressedString(string word)
{
      StringBuilder result = new StringBuilder();
  
int count = 1;

for (int i = 1; i < word.Length; i++)
{
    if (word[i] == word[i - 1])
    {
        if (count == 9)
        {
            result.Append( count + "" + Convert.ToChar(word[i - 1]));
            count = 1;
        }
        else
            count++;
    }
    else
    {
        result.Append(count + "" + Convert.ToChar(word[i - 1]));
        count = 1;
    }
}
result.Append( count + "" + Convert.ToChar(word[word.Length - 1]));
return result.ToString();
}
}