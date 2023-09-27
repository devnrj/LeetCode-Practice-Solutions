public class Solution {
    public int Search(int[] nums, int target) {
        return BinarySearch(nums,target,0,nums.Length-1);
    }
    private int BinarySearch(int[] nums, int target, int low, int high)
    {
        if(low<=high){
            int mid = (high-low)/2 + low;
            if(nums[mid]==target){
                return mid;
            }else if(nums[mid]<target){
                return BinarySearch(nums,target, mid+1,high);
            }else if(nums[mid]>target){
                return BinarySearch(nums,target,low,mid-1);
            }
        }
        
        return -1;
    }
}