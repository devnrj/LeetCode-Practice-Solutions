public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        IList<int> list = new List<int>();

        for (int number = left; number <= right; number++) {
            if (IsSelfDividing(number)) {
                list.Add(number);
            }
        }

        return list;
    }
    
    private bool IsSelfDividing(int number) {
        int originalNumber = number;
        
        while (number > 0) {
            int digit = number % 10;
            if (digit == 0 || originalNumber % digit != 0) {
                return false;
            }
            number /= 10;
        }
        
        return true;
    }
}
