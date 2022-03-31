public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        
        
  return Permute1( nums);
           
    
}
 public IList<IList<int>> Permute1(int[] nums,int index=0) {
        
        if (index== nums.Length)
                {
               
              IList<IList<int>> vs2 = new List<IList<int>>();
                return vs2;
                }
 
            int ch = nums[index];

              IList<IList<int>> list1= Permute1(nums, index + 1) ;
            if (list1.Count == 0)
            {
             List<int> vs = new List<int>() { nums[index] };
             list1.Add(vs);
                return list1;
            }
            else
            {
                int tt = nums[index];
                List<int> km = new List<int>() { nums[index] };
           IList<IList<int>> result = new List<IList<int>>();
                int t = 0;
                for (int i = 0; i <nums.Length-index ; i++)
                {  List<int> l  = new List<int>();
                    foreach (var item in list1)
                    {
                       l = new List<int>(item);
                      l.Insert(t, tt);
                    result.Add(l);
                    }
                    t++;

                }
                return result;

            }
    
}
}
