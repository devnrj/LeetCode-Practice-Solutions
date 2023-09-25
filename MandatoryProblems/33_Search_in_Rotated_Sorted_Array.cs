public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0, high = nums.Length-1;
        while(low<=high){
            int mid = low + (high-low)/2;
            if(target==nums[mid]){
                return mid;
            }else if(nums[low]<=nums[mid]){
                if(target>=nums[low] && target<nums[mid]){
                    high = mid-1;
                }else{
                    low = mid+1;
                }
            }else { 
                if(nums[mid]<target && target <= nums[high]){
                    low = mid+1;
                }else{
                    high = mid-1;
                }
            }
        }
        GC.Collect();
        return -1;
    }
}