public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        for(int row = 0 ; row<image[0].Length; row++){
            int length = image[0].Length-1;
            for(int col = 0, colPrime= length;
            col<colPrime;col++,
            colPrime--){
                int element = image[row][col];
                image[row][col]=image[row][colPrime] ^ 1;
                image[row][colPrime]=element ^ 1;
            }
            if(length%2==0){
                image[row][length/2]=image[row][length/2] ^1;
            }
        }

        return image;
    }
}