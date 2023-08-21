public class Solution {
    public int Fib(int n) {
        if(n == 1) {
            return 1;
        }

        int n1 = 0;
        int n2 = 1;
        int result =0;

        for(int i = 1; i < n; i++){
            result = n1 + n2;
            n1 = n2;
            n2 = result;
        }

        return result;

    }
}