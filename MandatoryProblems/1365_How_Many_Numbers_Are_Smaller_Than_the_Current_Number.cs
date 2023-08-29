public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] x = new int[101];
        int max = 0;
        for(int i =0;i<nums.Length;i++)
        {
            x[nums[i]] = x[nums[i]]+1;
            if(max <nums[i])
            {
                max=nums[i];
            }
        }
        int last = x[0];
        x[0] = 0;
        for(int i=1;i<=max;i++)
        {
            int t=x[i];
            x[i] =last;
            last = last+t;
        }
        for(int i =0;i<nums.Length;i++)
        {
            nums[i] = x[nums[i]];
        }
        return nums;
    }
}