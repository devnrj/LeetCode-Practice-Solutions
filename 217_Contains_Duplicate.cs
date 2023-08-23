public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> dict = new HashSet<int>();
        
        foreach(int num in nums){
            if(!dict.Add(num)) return true;
        }
        return false;
    }
}