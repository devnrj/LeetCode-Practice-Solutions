public class Solution {
    public int MaxCoins(int[] piles) {
        Array.Sort(piles);
        int res = 0;
        for(int i = 0, j=piles.Length-2; i<j; i++, j-=2){
            res+=piles[j];
        }
        return res;
    }
}

