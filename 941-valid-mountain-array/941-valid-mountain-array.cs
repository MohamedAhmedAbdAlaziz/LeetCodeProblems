public class Solution {
    public bool ValidMountainArray(int[] arr) {
         if (arr.Length < 3) return false;
         if(arr[arr.Length-1]>= arr[arr.Length - 2])
            {
                return false;
            } 
        if(arr[0]>= arr[1])
            {
                return false;
            } 
        
        int max= arr.Max();
            int i = 1;
  
            while (arr[i]< max && i< arr.Length)
            {
              if(arr[i-1]>= arr[i])
                {
                    break;
                }
                i++;
            }
            i++;
            while (i < arr.Length && arr[i] < max )
            {
                if (arr[i - 1] <= arr[i])
                {
                    break;
                }
                i++;
            }
            if (i == arr.Length)
            {
                return true;
            }

            return false;
    }
}