public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        string[] morseCodes = new string[]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        HashSet<string> set = new HashSet<string>();
        StringBuilder st = null;
        foreach(string word in words){
            st = new StringBuilder();
            foreach(char c in word.ToCharArray()){
                if((int)c >= 65 && c<=90){
                    st.Append(morseCodes[(int)c - 65]);
                }else if((int)c >= 97 && c<=122){
                    st.Append(morseCodes[(int)c - 97]);
                }
            }
            set.Add(st.ToString());
        }
        return set.Count();
    }
}