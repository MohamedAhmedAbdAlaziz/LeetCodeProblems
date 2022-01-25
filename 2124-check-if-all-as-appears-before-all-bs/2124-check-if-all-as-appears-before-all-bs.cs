public class Solution {
    public bool CheckString(string s) {
             int k = s.IndexOf('b');
            int km = s.LastIndexOf('a');
            if (k < km && k !=-1&& km !=-1 )
            {
                return false;
            }

            return true;
    }
}