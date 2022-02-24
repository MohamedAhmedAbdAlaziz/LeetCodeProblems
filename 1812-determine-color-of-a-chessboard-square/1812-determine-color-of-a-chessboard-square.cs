public class Solution {
    public bool SquareIsWhite(string coordinates) {
             Dictionary<char, int> prevSum = new Dictionary<char, int>();
            string t = "abcdefgh";
            for (int i = 0; i < 8; i++)
            {
                prevSum[t[i]] = i + 1;
            }

           if((prevSum[coordinates[0]]+Convert.ToInt16( coordinates[1].ToString())) % 2 == 0)
            {
                return false;
            }
                return true;
    }
}