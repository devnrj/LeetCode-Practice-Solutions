public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        Dictionary<char,int> set = new Dictionary<char,int>();
        int maxLength = 0, start = 0;
        for(int i = 0; i<s.Length; i++){
            if(set.ContainsKey(s[i])){
                start = Math.Max(start, set[s[i]] +1);
                set[s[i]] = i;
            }else{
                set.Add(s[i],i);
            }
            maxLength = Math.Max(maxLength, i-start +1);
        }
        return maxLength;
    }
}