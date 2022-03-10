public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
Dictionary<int, IList<int>> dic = new Dictionary<int, IList<int>>();
             IList<IList<int>> list = new List<IList<int>>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                int w = groupSizes[i];
               if(dic.ContainsKey(w))
                {
                    dic[w].Add(i);
                }    
                else
                {
                    dic[w] = new List<int> { i };
                }
            }
            foreach (var item in dic)
            {
                for (int i = 0; i < item.Value.Count(); i+=item.Key)
                {
                    var t = item.Value.Skip(i).Take(item.Key).ToList();
                    list.Add(t);
                }
            }

            return list;
    }
}