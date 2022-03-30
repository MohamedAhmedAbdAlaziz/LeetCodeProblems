public class Solution {
                 List<string> list = new List<string>();


    public IList<string> GenerateParenthesis(int n) {
        
         rec(n,n);
        return list;
        
    }
    
     public  void rec(int l,int r , string d = "")
        {
            
            if (l == 0 && r==0)
            {
                 list.Add(d);
               // Console.WriteLine(d);
                return;
            }
    
             if(l!=0)
            rec(l-1,r, d+  "(");
            if (r> l)
            rec(l, r-1,  d+")");
}
}