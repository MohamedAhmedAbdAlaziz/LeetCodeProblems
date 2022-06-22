public class Solution {
       int[] nums ;
    int sum ;
     Dictionary<int, int> dic = new Dictionary<int, int>();
               List<int> list = new List<int>();

    public Solution(int[] w) {
            nums= w;
           sum = nums.Sum();
            if(nums.Length> 1){
             for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(i))
                {
                    double t= (nums[i]* 1.0 / sum) * 100;
                    dic[i] =(int) t;

                }
            }
            
          foreach (var item in dic)
            { 
                    for (int i = 0; i < item.Value; i++)
                    {
                    list.Add(item.Key);
                  
                   }
                }

            }
       
    }
    
    public int PickIndex() {
        
        if(list.Count==0) return 0;
          Random random = new Random();
           int k= random.Next(0, list.Count);

        
         return list.Count==1? 0: list[k];
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(w);
 * int param_1 = obj.PickIndex();
 */