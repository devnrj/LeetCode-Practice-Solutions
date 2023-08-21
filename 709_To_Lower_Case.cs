public class Solution {
    public string ToLowerCase(string s) {
        StringBuilder result = new StringBuilder("");
        char[] message = s.ToCharArray();
        char converted = new char();
        foreach(char c in message){
            converted = c;
            if(c <= 'Z' && c>='A'){
                converted = (char)((int)c + 32);
            }
            result.Append(converted);
            
        }
        return result.ToString();
    }
}