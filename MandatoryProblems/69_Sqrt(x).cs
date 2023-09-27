public class Solution {
    public int MySqrt(int x) {
        if(x==0) return x;
        int low = 1, high = x, mid,ans =0;

        while(low<=high){
            mid = low + (high-low)/2;
            if(mid<=x/mid){
                ans = mid;
                low = mid+1;
            }else{
                high = mid-1;
            }
        }
        return ans;
    }
}