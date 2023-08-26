public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        
        for(int i = 0;i <nums.Length; i++){
            int val = 0;
            bool found = dict.TryGetValue(target-nums[i],out val);
            if(found == true){
                return new int[]{val,i};
            }
            int dummy = 0;
            if(!found && !dict.TryGetValue(nums[i],out dummy)){
                dict.Add(nums[i],i);   
            }
        }
        return null;
    }
}