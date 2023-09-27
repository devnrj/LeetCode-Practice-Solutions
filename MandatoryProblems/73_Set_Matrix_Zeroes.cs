public class Solution {
    public void SetZeroes(int[][] matrix) {
        List<(int,int)> locations = new List<(int,int)>();
        for(int i = 0; i<matrix.Length; i++){
            for(int j = 0; j<matrix[0].Length; j++){
                if(matrix[i][j]==0){
                    locations.Add((i,j));
                }
            }
        }
        foreach(var location in locations){
            var i = location.Item1;
            var j = location.Item2;

            for (int k = 0; k < matrix.Length; k++) {
                matrix[k][j] = 0;
            }
            for (int k = 0; k < matrix[0].Length; k++) {
                matrix[i][k] = 0;
            }
        }
    }
}