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

// with Hashset Variation

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int left = 0, right = 0, maxLength = 0;
        while(right<s.Length){
            if(!set.Contains(s[right])){
                set.Add(s[right]);
                right++;
                maxLength = Math.Max(maxLength, set.Count);
            }else{
                set.Remove(s[left]);
                left++;
            }
        }
        return maxLength;
    }
}