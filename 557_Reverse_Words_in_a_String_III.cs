public class Solution {
    public string ReverseWords(string s) {
        int lIndex = -1;
        char[] sChar = s.ToCharArray();
        int len = s.Length;
        for(int i = 0; i<=len ; i++){
            if(i==len||sChar[i]==' '){
                int sIndex = lIndex+1;
                int eIndex = i-1;
                while(sIndex<eIndex){
                    char temp = sChar[sIndex];
                    sChar[sIndex] = sChar[eIndex];
                    sChar[eIndex] = temp;
                    sIndex++;
                    eIndex--;
                }
                lIndex = i;
            }
        }
        return new string(sChar);
    }
}