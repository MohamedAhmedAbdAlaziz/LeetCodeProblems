public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
                Dictionary<string, int[]> dic = new Dictionary<string, int[]>();
            
            for (int i = 0; i < list1.Length; i++)
            {
                dic[list1[i]] = new int[] {i,0};
            }

            for (int i = 0; i < list2.Length; i++)
            {
                if (dic.ContainsKey(list2[i]))
                {
                    dic[list2[i]][0] = dic[list2[i]][0] + i;
                    dic[list2[i]][1] += 1;

                }
                
            }

             int y = dic.Where(x => x.Value[1] == 1).Min(x => x.Value[0] );

            return dic.Where(x => x.Value[0] == y && x.Value[1] == 1).Select(x => x.Key).ToArray();



    }
}