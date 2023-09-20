public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0) return "";

        string prefix = strs[0];
        for (int i=1; i<strs.Length; i++)
        {
            while(strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix[..^1];
                if (string.IsNullOrEmpty(prefix)) return "";
            }
        }
        return prefix;
    }
}

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int minLength = Int32.MaxValue;
        int smallestStringIdx = 0;
        for(int i = 0; i<strs.Length; i++){
            minLength = Math.Min(strs[i].Length, minLength);
            if(strs[i].Length == minLength){
                smallestStringIdx = i;
            }
        }
        Console.WriteLine(smallestStringIdx);
        int lastIndex = 0;
        for(int i = 0; i<strs.Length; i++){
            int j = 0;
            while(j<minLength){
                if(strs[i][j] !=strs[smallestStringIdx][j]){
                    lastIndex = j;
                    if(lastIndex==0){
                        return "";
                    }
                    break;
                }
            }
        }
        return lastIndex == 0 ? "" : strs[smallestStringIdx].Substring(0,lastIndex);
    }
}
