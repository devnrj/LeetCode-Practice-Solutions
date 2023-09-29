public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int j = n-1, i=m-1,index = m+n-1;
        while(j>=0){
            if(i>=0 && nums1[i] > nums2[j]){
                nums1[index]=nums1[i];
                index--;
                i--;
            }else{
                nums1[index]=nums2[j];
                index--;
                j--;
            }
        }

    }
}