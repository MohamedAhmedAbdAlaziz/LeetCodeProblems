public class CustomStack {

    int []arr ;
        int size=0;
        int element=0;
        int MaxSize = 0;
        public CustomStack(int maxSize)
        {
            this.arr = new int[maxSize];
            this.MaxSize = maxSize;
        }

        public void Push(int x)
        {
            if (element <= MaxSize-1)
            {
                arr[element++] = x;
                
            }
        }

        public int Pop()
        {
            if (element==0)return -1;
           
            return arr[--element ];
        }

        public void Increment(int k, int val)
        {
            if (k < element)
            {
                for (int i = 0; i < k; i++)
                {
                    arr[i] += val;
                }
            }else
            {
                for (int i = 0; i < element; i++)
                {
                    arr[i] += val;
                }
            }
        }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */