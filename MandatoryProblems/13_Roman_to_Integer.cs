public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> dict = new Dictionary<char,int>{{'I',1},{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}};
        
        
        int result = dict[s[s.Length-1]];
        for(int i = s.Length-2; i >= 0 ; i--){
            if(dict[s[i+1]]>dict[s[i]]){
                result -= dict[s[i]];
                continue;
            }
            
            result = result + dict[s[i]];
            
        }
        return result;
    }
}