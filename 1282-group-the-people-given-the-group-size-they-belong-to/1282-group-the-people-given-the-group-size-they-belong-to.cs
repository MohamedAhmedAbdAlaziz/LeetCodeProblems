public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
Dictionary<int, IList<int>> dic = new Dictionary<int, IList<int>>();
             IList<IList<int>> list = new List<IList<int>>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                 
               if(dic.ContainsKey(groupSizes[i]))
                    dic[groupSizes[i]].Add(i); 
                else
                    dic[groupSizes[i]] = new List<int> { i };
            }
            foreach (var item in dic)
            {
                for (int i = 0; i < item.Value.Count(); i+=item.Key)
                  list.Add( item.Value.Skip(i).Take(item.Key).ToList());
                  }

            return list;
    }
}