public class Solution {
    public int FindNumbers(int[] nums) {
        int result = 0;
        foreach(int num in nums){
            if(num.ToString().Length%2 == 0){
                ++result;
            }
        }
        GC.Collect();
        return result;
    }
}