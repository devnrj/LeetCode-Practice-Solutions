public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int low = 0,high=arr.Length-1;
        while(low<high){
            int mid = low + (high-low)/2;
            if(arr[mid]<arr[mid+1]){
                low = mid+1;
            }else{
                high=mid;
            }
        }

        return low;
    }
}