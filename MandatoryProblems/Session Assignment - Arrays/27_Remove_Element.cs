public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int j = 0;
        for(int i = 0; i<nums.Length; i++){
            if(val!= nums[i]){
                nums[j++]=nums[i];
            }
        }
        return j;
    }
}