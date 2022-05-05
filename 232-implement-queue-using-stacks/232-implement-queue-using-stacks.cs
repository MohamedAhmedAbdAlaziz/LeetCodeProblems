public class MyQueue {

    Stack<int> t;
        public MyQueue()
        {
          t = new Stack<int>();
        }

        public void Push(int x)
        {
            t.Push(x);

        }

        public int Pop()
        {
       Stack<int> t2 = new Stack<int>();
            while (t.Count!=1)
            {
                t2.Push(t.Pop());
            }
            int tm = t.Pop();
            while (t2.Count > 0)
            {
                t.Push(t2.Pop());

            }
                    return tm;

        }

        public int Peek()
        {
           Stack<int> t2 = new Stack<int>();
            while (t.Count != 1)
            {
                t2.Push(t.Pop());
            }

            int tm = t.Peek();
            t2.Push(t.Pop());
            while (t2.Count > 0)
            {
                t.Push(t2.Pop());

            }
            return tm;
        }

        public bool Empty()
        {
            return t.Count == 0;
        }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */