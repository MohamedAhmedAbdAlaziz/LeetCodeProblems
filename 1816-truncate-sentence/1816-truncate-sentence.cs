public class Solution {
    public string TruncateSentence(string s, int k) {
         string[] news = s.Split(" ");
              return string.Join(" ", news.Take(k));
    }
}