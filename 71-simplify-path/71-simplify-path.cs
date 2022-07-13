public class Solution {
    public string SimplifyPath(string path) {
        string[] arr = path.Split('/');
        Stack<string> stack = new Stack<string>();

        for (int i = 0; i < arr.Length; i++){
            if (arr[i] != ""){
                if (arr[i] == ".."){
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else if (arr[i] == ".")
                {
                }
                else
                {
                    stack.Push(arr[i]);
                }
            }
        }
        StringBuilder sb = new StringBuilder();

        while (stack.Count > 0){
            sb.Insert(0, "/" + stack.Pop());
        }

        //solve corner case like "/../"
        if (sb.Length == 0)
            sb.Append("/");

        return sb.ToString();
    }
}