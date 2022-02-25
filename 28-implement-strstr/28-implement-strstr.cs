public class Solution {
    public int StrStr(string haystack, string needle) {
        int haystackLength=haystack.Length;
        int needleLength=needle.Length;
        if (haystackLength<needleLength) return -1;
        if (needleLength==0) return 0;
        for (int i=0; i<haystackLength; i++){
            if (haystack[i]==needle[0] && (needleLength<=haystackLength-i)) {
                if (haystack.Substring(i, needleLength)==needle) return i;
            }
        }
        return -1;
    }
}