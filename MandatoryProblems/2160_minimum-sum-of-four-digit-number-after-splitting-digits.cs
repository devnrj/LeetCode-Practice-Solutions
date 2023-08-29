public class Solution {
    public int MinimumSum(int num) {
        int[] digits = new int[4];
        for(int i = 0; i < 4; i++){
            digits[i] = num%10;
            num /= 10;
        }
        for(int i= 0; i<4;i++){
            for(int j = i+1;j<4;j++){
                if(digits[i]>digits[j]){
                    digits[i]+=digits[j];
                    digits[j]=digits[i]-digits[j];
                    digits[i]=digits[i]-digits[j];
                }
            }
        }

        return digits[0]*10 + digits[2] + digits[1]*10 + digits[3];
    }
}