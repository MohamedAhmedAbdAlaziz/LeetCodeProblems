public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
                  for (int i = 0; i < image.Length; i++)
            {


                for (int j = 0; j <(image[i].Length / 2); j++)
                {
                   
                        int temp = image[i][image.Length - 1 - j];
                        image[i][image[i].Length - 1 - j] = image[i][j];
                        image[i][j] = temp;
                        image[i][image[i].Length - 1 - j] = image[i][image[i].Length - 1 - j] == 0 ? 1 : 0;

                 
                    image[i][j] = image[i][j] == 0 ? 1 : 0;


                }
                if((image[i].Length % 2)!=0)
                {
                    image[i][image[i].Length / 2]= image[i][image[i].Length / 2]==0? 1 : 0;
                }
            }
            return image;
    }
}