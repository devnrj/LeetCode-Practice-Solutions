public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        Array.Sort(nums);
        var list = new List<int>();
        int left = binarySearch(nums,target,false);
        
        if(left == -1){
            return list;
        }
        int right = binarySearch(nums,target,true);
        
        while(left<=right){
            list.Add(left);
            left++;
        }
        return list;
    }
    private int binarySearch(int[] nums, int target,bool isRight) {
        int left = 0;
        int right = nums.Length - 1;
        int result = -1;
        int mid;
        while (left <= right) {
            mid = left + (right - left) / 2;
            if (nums[mid] == target) {
                result = mid;
                if(isRight){
                    left = mid + 1;
                }else{
                    right = mid - 1;
                }
            } else if (nums[mid] < target) {
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return result;
    }
}