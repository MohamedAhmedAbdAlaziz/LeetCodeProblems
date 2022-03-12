public class Solution {
    public bool CanBeIncreasing(int[] nums) {
         int y = 0;
            for (int i = 0; i < nums.Length; i++)
            {
            List<int> list = new List<int>(nums);
                list.RemoveAt(i);
                y = 1;
                    for (int j = 1; j < list.Count(); j++)
                   {
                    if (list[j] <= list[j - 1])
                        break;

                    y++;
                   }
                if (y == list.Count)
                {
                    return true;
                }

            }
            return false;

    }
}