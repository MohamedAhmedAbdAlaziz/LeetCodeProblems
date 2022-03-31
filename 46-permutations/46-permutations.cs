public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        
        
  return Permute1( nums);
           
    
}
 public IList<IList<int>> Permute1(int[] nums,int index=0) {
        
        if (index== nums.Length)
                {
               // List<List<int>> vs2 = new List<List<int>>();
              IList<IList<int>> vs2 = new List<IList<int>>();
                return vs2;
                }


            //   string str = s.Substring(0, i);
            // string qrpart = s.Substring(i + 1);
            //string roq = str + qrpart;
            int ch = nums[index];

              IList<IList<int>> list1= Permute1(nums, index + 1) ;
            // List<int> vs = new List<int>() { arry[index] };
            //  vs2.Add(vs);
            List<int> vs = new List<int>() { nums[index] };
            if (list1.Count == 0)
            {
               list1.Add(vs);
                return list1;
            }
            else
            {
                int tt = nums[index];
                List<int> km = new List<int>() { nums[index] };
              //  List<List<int>> result = new List<List<int>>();
           IList<IList<int>> result = new List<IList<int>>();

                int t = 0;
                for (int i = 0; i <nums.Length-index ; i++)
                {
                  //  List<List<int>> l = new List<List<int>>(list1);// { list1 };
                 List<int> l  = new List<int>();
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
