public class Solution {
    public char[] ReverseString(char[] s) {
        
        for(int i =0 , j=s.Length-1; i<j;i++,j--){
            char temp = s[i];
            s[i]=s[j];
            s[j]=temp;
        }
        return s;
    }
}