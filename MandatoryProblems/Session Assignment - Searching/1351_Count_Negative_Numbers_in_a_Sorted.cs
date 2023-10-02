public class Solution {
    public int CountNegatives(int[][] grid) {
        int count = 0;
        foreach(var arr in grid){
            count+=BinarySearch(arr);
        }
        return count;
    }

    private int BinarySearch(int[] arr){
        int low = 0, high = arr.Length-1, mid = 0;
 
        while(low<=high){
            mid = (high-low)/2 + low;
            if(arr[mid]>=0){
                low = mid+1;
            }else{
                high = mid-1;
            }
        }

        return arr.Length - low;
    }
}