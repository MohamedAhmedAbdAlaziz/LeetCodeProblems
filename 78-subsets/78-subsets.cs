public class Solution {
    public IList<IList<int>> Subsets(int[] nums ,int index=0) {
        if (index == nums.Length )
            {
                return new List<IList<int>>() { new List<int>() };
            }
            int t = index;
            IList<IList<int>> list = Subsets( nums,  index+1);
            if (list.Count() == 1)
            {
                list.Add(new List<int>() {nums[t] });
                return list;
            }
            
                List<IList<int>> g = new List<IList<int>>()  ;
                
                    g.AddRange(list);
                   foreach (var item in list)
                        {
                    List<int> yf = new List<int>();
                    yf.AddRange(item);
                        yf.Insert(0,nums[index]);
                    g.Add(yf);

                }
           return g;
            
    }
}