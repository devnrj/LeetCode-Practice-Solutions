public class Solution {
    public IList<int> PancakeSort(int[] arr) {
        void flip(int idx){
            int l = 0, r = idx;
            while(l < r)
                (arr[l],arr[r]) = (arr[r--],arr[l++]);
        }
        List<int> res = new List<int>();
        for(int i = arr.Length - 1; i >= 0;i--){
            if(arr[i] == i + 1) continue;
            for(int j = 1; j < i && arr[0] != i + 1;j++){
                if(arr[j] == i + 1){
                    flip(j);
                    res.Add(j + 1);
                } 
            }
            flip(i);
            res.Add(i + 1);
        }
        return res;
    }
}