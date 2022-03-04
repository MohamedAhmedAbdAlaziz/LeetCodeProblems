public class Solution {
    public bool JudgeCircle(string moves) {
        int sum = 0;

            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i]=='U')
                {
                    sum += 2;
                }
                else if(moves[i] == 'D')
                {
                    sum += -2;

                }
                else if (moves[i] == 'R')
                {
                    sum += -5;
                }
                else 
                {
                    sum += 5;

                }

                
            }
            if (sum == 0) return true;
            return false;
    }
}