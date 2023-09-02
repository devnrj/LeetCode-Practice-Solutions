public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        for(int i = 0, j=0; i<nums.Length && j<nums.Length ; ){
            if(nums[i]%2==0){
                int temp = nums[i];
                nums[i]=nums[j];
                nums[j] = temp;
                j++;           
            }
            i++;
        }

        return nums;
    }
}