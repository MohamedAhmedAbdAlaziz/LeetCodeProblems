public class Solution {
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
          string k = "abcdefghijklmnopqrstuvwxyz";
            string t="", m="", r="";
            for (int i = 0; i < firstWord.Length; i++)
            {
              
                 t +=k.IndexOf(firstWord[i]).ToString();

            }
            for (int i = 0; i < secondWord.Length; i++)
            {

                m += k.IndexOf(secondWord[i]).ToString();
            }
            for (int i = 0; i < targetWord.Length; i++)
            {

                r+= k.IndexOf(targetWord[i]).ToString();
            }

            if(Convert.ToInt32(t)+Convert.ToInt32(m)== Convert.ToInt32(r))
            {
                return true;
            }
            return false;
    }
}