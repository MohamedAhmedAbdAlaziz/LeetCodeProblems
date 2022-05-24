public class Solution {
    public int ScoreOfParentheses(string s) {
              Stack<int> statck = new Stack<int>();
            int score = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    statck.Push(score);
                    score = 0;
                }
                else
                {
                    score = statck.Pop() + Math.Max(score * 2, 1); 
                }
            }
            return score;
    }
}