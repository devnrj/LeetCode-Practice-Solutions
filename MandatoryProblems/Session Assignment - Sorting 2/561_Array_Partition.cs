public class Solution {
    int K = 10000;
    public int ArrayPairSum(int[] nums) {
        
        int[] elementToCount = new int[2 * K + 1];
        foreach(int element in nums) {
            elementToCount[element + K]++;
        }
        
        int maxSum = 0;
        bool isEvenIndex = true;
        for (int element = 0; element <= 2 * K; element++) {
            while (elementToCount[element] > 0) {
                maxSum += (isEvenIndex ? element - K : 0);
                isEvenIndex = !isEvenIndex;
                elementToCount[element]--;
            }
        }
        return maxSum;
    }
}