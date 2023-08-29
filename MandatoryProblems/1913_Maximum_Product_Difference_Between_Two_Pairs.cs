public class Solution {
    public int MaxProductDifference(int[] nums) {
        int max1=Int32.MinValue;
        int max2=Int32.MinValue;
        int min1=Int32.MaxValue;
        int min2=Int32.MaxValue;
        foreach(int num in nums){
            if(num>max1){
                max2 = max1;
                max1 = num;
            }else if(num>max2){
                max2 = num;
            }

            if(num<min1){
                min2 = min1;
                min1 = num;
            }else if(num<min2){
                min2 = num;
            }
        }

        return ((max1*max2)-(min1*min2));
    }
}