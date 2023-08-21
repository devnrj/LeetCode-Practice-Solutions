public class Solution {
    public void MoveZeroes(int[] nums) {
        int i = 0, j = 1;
        while(j<nums.Length){
            if(nums[i]==0){
                nums[i]=nums[j];
                nums[j]=0;
            }
            if(nums[i]!=0){
                    i++;     
                }
            j++;
        }
    }
}