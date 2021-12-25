public class Solution {
    public string Interpret(string command) {
      
            string k = command.Replace("()", "o");
            k = k.Replace("(", "");
            k = k.Replace(")", "");


            return k;  
    }
}