public class Solution {
    public int CountPoints(string rings) {
      int[] Red = new int[10];
          int[] Blue = new int[10];
          int[] Green = new int[10];

            for (int i = 0; i < rings.Length; i+=2)
            {
                int y =Convert.ToInt32( rings[i + 1].ToString());

                switch (rings[i])
                {

                    case 'B':
                    Blue[y]++;
                        break;
                    case 'G':
                        Green[y]++;
                        break;
                    default:
                        Red[y]++;
                        break;

                };
                
            }
            int k=0;
            for (int i = 0; i < 10; i++)
            {
                if (Red[i] < 1 || Green[i] < 1 || Blue[i] < 1)
                    continue;
                else
                {
                    k++;
                }
            }
            return k;   
    }
}