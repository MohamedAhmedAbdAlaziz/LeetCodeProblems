public class Solution {
    public string ReverseWords(string s) {
      return String.Join(" ", s.Split()
                 .Select(x => new string(x.Reverse().ToArray())
                 ));
    }
}