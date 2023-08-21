public class Solution {
    public bool IsMonotonic(int[] nums) {
        int prevTone = 0;
        bool isMonotone = true;
        for(int i  = 0 ; i<nums.Length-1 ; i++){
            int tone = 0;
            if(nums[i+1]<nums[i]){
                tone = -1;
            }else if(nums[i+1]>nums[i]){
                tone = 1;
            }
            if(prevTone != 0 && tone != 0 && prevTone!=tone){
                isMonotone = false;
                break;
            }else if(prevTone == 0 && tone != 0){
                prevTone=tone;
            }
        }
        return isMonotone;
    }
}