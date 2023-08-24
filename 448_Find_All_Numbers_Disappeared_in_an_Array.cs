public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> result = new List<int>();
        int index = -1;
        for(int i = 0 ; i<nums.Length;i++){
            if(nums[i] < 0){
                index = nums[i] * -1 -1;
            }else{
                index = nums[i] -1;
            }
            if(nums[index]>0){
                nums[ index ]*=-1;
            }
        }
        for(int i = 0 ; i<nums.Length; i++){
            if(nums[i]>0){
                result.Add(i+1);
            }
        }

        return result;
    }
}