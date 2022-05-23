public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
          //Array.Sort(nums);
         //   List<int> list = new List<int>();
            return nums.OrderBy(x=>x).Select((x,y) => new   { 
            itemName = x,
            postion = y
            }).Where(x => x.itemName == target).Select(x=>x.postion).ToList();
            
    }
}