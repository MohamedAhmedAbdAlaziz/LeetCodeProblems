public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
          int[] hash = new int[1001];

            for (int i = 0; i < arr1.Length; i++)
            {
                hash[arr1[i]]++;
            }
         
            List<int> list = new List<int>();
            for(int i = 0; i < arr2.Length; i++)
            { 
               int k = arr2[i];
              int t = hash[k];
               arr1 = arr1.Where(x => x != arr2[i]).ToArray();
                    for (int j = 0; j <t; j++)
                    {
                        list.Add(arr2[i]);
                    
                    }
              }
          
            Array.Sort(arr1);

            list.AddRange(arr1);

            return list.ToArray();
    }
}