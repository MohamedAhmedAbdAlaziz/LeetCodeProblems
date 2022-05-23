public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
           return nums.OrderBy(x=>x).Select((x,y) => new   { 
            itemName = x,
            postion = y
            }).Where(x => x.itemName == target).Select(x=>x.postion).ToList();
            
    }
}