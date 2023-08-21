public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Dictionary<int,int> dt = new Dictionary<int,int>();
        Stack<int> st = new Stack<int>();

        for(int i = nums2.Length-1; i>=0; i--){
            while(st.Count > 0 && st.Peek() <= nums2[i]){
                st.Pop();
            }
            if (st.Count != 0) {
                dt.Add(nums2[i], st.Peek());
            } else {
                dt.Add(nums2[i], -1);
            }
            st.Push(nums2[i]);
        }

        for(int i = 0 ; i<nums1.Length; i++){
            nums1[i] = dt[nums1[i]];
        }

        return nums1;
    }
}