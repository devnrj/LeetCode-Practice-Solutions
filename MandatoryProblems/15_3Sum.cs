public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var res = new List<IList<int>>();
        for(int i = 0; i<nums.Length-2;i++){
            if(i==0 || (i>0 && nums[i]!=nums[i-1])){
                int low = i+1;
                int high = nums.Length-1;
                int sum = 0-nums[i];
                while(low<high){
                    if(nums[low]+nums[high] == sum){
                        res.Add(new List<int>{nums[i],nums[low],nums[high]});
                        while(low<high && nums[low]==nums[low+1]) low++;
                        while(low<high && nums[high]==nums[high-1]) high--;
                        low++;
                        high--;
                    }
                    else if(nums[low]+nums[high]>sum){
                        high--;
                    }else{
                        low++;
                    }
                }
            }
        }
        return res;
    }
}