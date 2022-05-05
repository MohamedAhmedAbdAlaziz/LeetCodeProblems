public class MyStack {
        Queue<int>  Q = new Queue<int>(); 
      public MyStack() {
        
     Q = new Queue<int>(); 

    }
    
    public void Push(int x) {
         Q.Enqueue(x);
    }
    
   public int Pop()
        {  Queue<int> Q2 = new Queue<int>();
            while (Q.Count != 1)
            {
                Q2.Enqueue(Q.Dequeue());
            }
            int tt = Q.Dequeue();
            Q = Q2;
            return tt;
        }

        public int Top()
        {
            Queue<int> Q2 = new Queue<int>();
            while (Q.Count != 1)
            {
                Q2.Enqueue(Q.Dequeue());
            }
            int tt = Q.Peek();
            Q = Q2;
            Q.Enqueue(tt);
            return tt;
        }
    
    public bool Empty() {
        return Q.Count==0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */