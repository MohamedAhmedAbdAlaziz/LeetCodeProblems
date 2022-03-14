public class Solution {
    public int Fib(int n) {
        if(n<=1)return n;
        
        int a= Fib(n-1);
        int b= Fib(n-2);
        return a+b;

        
    }
}