public class Solution {
    public string ReverseWords(string s) {
       
        string[] sarry = s.Split(" ");
            List<string> list = new List<string>();
            for (int i = sarry.Length-1; i >=0 ; i--)
            {
    if(sarry[i] != "")

                list.Add(sarry[i]);
            }
           
            return String.Join(" ", list);
    }
}