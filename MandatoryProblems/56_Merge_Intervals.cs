public class Solution {
    public int[][] Merge(int[][] intervals) {
        if(intervals==null || intervals.Length==1)
            return intervals;
        List<int[]> list = new List<int[]>();
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));
        int j = 0;
        list.Add(intervals[0]);
        for(int i = 1 ; i<intervals.Length; i++){
            if(list[j][1]>=intervals[i][0]){
                list[j][1] = Math.Max(list[j][1],intervals[i][1]);
            }else{
                j++;
                list.Add(intervals[i]);
            }
        }
        return list.ToArray();
    }
}