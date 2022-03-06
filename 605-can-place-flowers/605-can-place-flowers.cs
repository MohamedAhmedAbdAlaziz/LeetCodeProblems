public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
         if(n==0)return true;
        
        if(flowerbed.Length==1 &&flowerbed[0]==0){
            return true;
        }
            if(flowerbed.Length==1 &&flowerbed[0]==1){
            return false;
        }
        
        
        if (flowerbed[0]==0 && flowerbed[1]  == 0)
        {
            flowerbed[0] = 1;
                    n--;
              if (n == 0)
                     {
                    return true;
                    }
        }
        
        for (int i = 1; i <flowerbed.Length-1; i++)
            {
               if (flowerbed[i]==0 && flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
               {
                    flowerbed[i] = 1;
                    n--;

                    
                     if (n == 0)
                     {
                    return true;
                    }
                }
               
            }
          if (flowerbed[flowerbed.Length-1]==0 && flowerbed[flowerbed.Length-2]  == 0)
        {
            flowerbed[flowerbed.Length-1] = 1;
                    n--;
        }
         if (n == 0)
                 {
                    return true;
                }
        
        
               return false;
    }
}