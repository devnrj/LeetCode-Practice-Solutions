public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        return binarySearch(nums);
    }

    private int binarySearch(int[] nums) {
        int left = 0;
        int right = nums.Length/2;
        int mid;
        while (left < right) {
            mid = left + (right - left) / 2;
            if(nums[mid*2]==nums[mid*2+1]){
                left = mid+1;
            }else{
                right = mid;
            }
        }

        return nums[left*2];
    }
}