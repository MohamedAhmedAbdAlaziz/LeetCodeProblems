public class Solution {
    public string DefangIPaddr(string address) {
         string s ="";
            for (int i = 0; i < address.Length; i++)
            {

                if (address[i] == '.')
                {
                    s += "[" + address[i] + "]";
                }
                else
                {
                    s +=  address[i] ;
                }
            }
            return s;
    }
}