public class Solution {
    public void Rotate(int[][] matrix) {
         List<List<int>> list = new List<List<int>>();
            for (int i = 0; i < matrix[0].Length; i++)
            {
              List<int> l = new List<int>();
                   for (int j = 0; j < matrix.Length; j++)
                     l.Insert(0,matrix[j][i]);
                   list.Add(l);
                
                 }

            for (int i = 0; i < matrix[0].Length; i++)
                  matrix[i]= list[i].ToArray();
         
              

    }
}