public class Solution {
    public int Trap(int[] height) {
        int left= 0, right = height.Length-1, res = 0,lMax = height[left], rMax = height[right];
        while(left<=right){
            if(height[left]<=height[right]){
                if(height[left]>=lMax){
                    lMax = height[left];
                }else{
                    res += lMax - height[left];
                }
                left++;
            }else{
                if(height[right]>=rMax){
                    rMax = height[right];
                }else{
                    res += rMax - height[right];
                }
                right--;
            }
        }
        return res;
    }
}