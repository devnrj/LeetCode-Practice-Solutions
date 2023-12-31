public class Solution {
    public void Rotate(int[][] matrix) {
        for(int i = 0; i<matrix.Length; i++){
            for(int j = i; j<matrix.Length; j++){
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
        int end = matrix.Length-1;
        for(int i = 0; i<matrix.Length; i++){
            for(int j = 0; j<matrix.Length/2; j++){
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][end-j];
                matrix[i][end-j] = temp;
            }
        }
        GC.Collect();
    }
}