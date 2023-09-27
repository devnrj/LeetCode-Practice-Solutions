public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();
        DFS(result,new List<int>(),nums,0);
        return result;
    }

    public void DFS(List<IList<int>> result, List<int> sub, int[] nums, int i){
        result.Add(new List<int>(sub));
        for(int k = i; k<nums.Length; k++){
            sub.Add(nums[k]);
            DFS(result,sub,nums,k+1);
            sub.RemoveAt(sub.Count-1);
        }
    }
}