public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
      int k = 0;
            switch (ruleKey)
                {
                case "type":
                    k = 0; 
                    break;

                case "color":
                    k = 1;
                    break;
                default:
                    k = 2;
                    break;

            };
                 int l = 0;
            foreach (var item in items)
            {
                if(item[k] == ruleValue)
                {
                    l++;
                }
            }
            return l;
               
    }
}