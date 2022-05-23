public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
       var y=   Subsets(nums );
          var dic = new Dictionary< string , IList<int>>();
             
          
            dic[""] = new List<int> { };
            foreach (var item in y)
            {
                var yy = "";
                if (item.Count > 0)
                {
                     yy = item.OrderBy(x=>x).Select(x => x.ToString()).Aggregate((x, y) => x + "" + y);
                    if (!dic.ContainsKey(yy))
                    {
                        dic[yy] = item;

                    }
                }
                // var yy=item.Select(x=>x.ToString()).Aggregate((x,y)=>x+""+y);
                

            }

           return dic.Select(x => x.Value).ToList();
    }
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