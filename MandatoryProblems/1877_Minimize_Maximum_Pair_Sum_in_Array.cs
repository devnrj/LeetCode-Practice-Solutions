public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);
        int res = 0;
        int i = 0,j = nums.Length-1;
        while(i<j){
            res = Math.Max(res,nums[i]+nums[j]);
            i++;
            j--;
        }
        return res;
    }
}